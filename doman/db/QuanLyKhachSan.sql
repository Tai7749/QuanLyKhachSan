-- =========================================================
-- FILE: QLKS_created-table.sql 
-- =========================================================
-- NOTE:
-- 1) Dùng INDEX để tối ưu truy vấn cho các bảng hay dùng:
--    - NHANVIEN, KHACHHANG, PHONG, DATPHONG, CHITIET_DATPHONG, HOADON, CHITIET_DICHVU
--
-- 2) KHÔNG dùng computed column, trigger, function để tính tiền trong SQL.
--    - Mọi logic tính tiền (tiền phòng, tiền dịch vụ, tổng tiền, VAT, giảm giá, phụ phí...)
--      đều thực hiện ở phía C# (WinForms).
--
-- 3) Các cột tiền trong DB (TongTienPhong, TongTienDichVu, ThanhTien, ...) chỉ dùng để:
--    - Lưu kết quả đã tính từ C#
--    - Phục vụ hiển thị, báo cáo, thống kê
--
-- 4) Dùng VARCHAR cho các cột mã (MaNV, MaKH, MaPhong, MaHD, ...) để:
--    - Dễ sinh mã ở C#
--    - Linh hoạt khi đổi format mã (VD: NV001, KH2026_01, ...)
--
-- 5) Các CHECK CONSTRAINT chỉ dùng để:
--    - Validate dữ liệu cơ bản (>= 0, > 0, enum trạng thái, ngày tháng hợp lệ, ...)
--    - KHÔNG chứa logic nghiệp vụ tính toán tiền
--
-- 6) Database chỉ đóng vai trò:
--    - Lưu trữ dữ liệu
--    - Ràng buộc toàn vẹn (PK, FK, CHECK, UNIQUE)
--    - Tối ưu truy vấn bằng INDEX
--    - Nghiệp vụ và tính toán thuộc về tầng C# (Business Logic)
-- =========================================================


-- ==================== 1) BỘ PHẬN ====================
CREATE TABLE dbo.BOPHAN (
    MaBP VARCHAR(10) PRIMARY KEY,
    TenBP NVARCHAR(50) NOT NULL UNIQUE
);

-- ==================== 2) NHÂN VIÊN ====================
CREATE TABLE dbo.NHANVIEN (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NULL,
    GioiTinh NVARCHAR(10) NULL CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    CCCD VARCHAR(12) NULL UNIQUE,
    DienThoai VARCHAR(15) NULL UNIQUE,
    MatKhau VARCHAR(100) NOT NULL,
    MaBP VARCHAR(10) NULL,
    QuyenMacDinh VARCHAR(20) NOT NULL
        CHECK (QuyenMacDinh IN ('Admin', 'QuanLy', 'LeTan')),
    TrangThai BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_NHANVIEN_BOPHAN FOREIGN KEY (MaBP) REFERENCES dbo.BOPHAN(MaBP)
);

CREATE INDEX IX_NV_DienThoai ON dbo.NHANVIEN(DienThoai);
CREATE INDEX IX_NV_TrangThai ON dbo.NHANVIEN(TrangThai);

-- ==================== 3) KHÁCH HÀNG ====================
CREATE TABLE dbo.KHACHHANG (
    MaKH VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    CCCD VARCHAR(12) NULL,
    DienThoai VARCHAR(15) NULL,
    Email VARCHAR(50) NULL,
    QuocTich NVARCHAR(30) NOT NULL DEFAULT N'Việt Nam'
);

CREATE INDEX IX_KH_DienThoai ON dbo.KHACHHANG(DienThoai);
CREATE INDEX IX_KH_CCCD ON dbo.KHACHHANG(CCCD);
CREATE INDEX IX_KH_Email ON dbo.KHACHHANG(Email);

-- ==================== 4) LOẠI PHÒNG ====================
CREATE TABLE dbo.LOAIPHONG (
    MaLoaiPhong VARCHAR(10) PRIMARY KEY,
    TenLoaiPhong NVARCHAR(50) NOT NULL UNIQUE,
    DonGia INT NOT NULL CHECK (DonGia > 0),
    SoNguoi INT NULL CHECK (SoNguoi > 0),
    SoGiuong INT NULL CHECK (SoGiuong > 0),
    MoTa NVARCHAR(500) NULL
);

-- ==================== 5) PHÒNG ====================
CREATE TABLE dbo.PHONG (
    MaPhong VARCHAR(10) PRIMARY KEY,
    MaLoaiPhong VARCHAR(10) NOT NULL,
    TenPhong NVARCHAR(30) NOT NULL,
    Tang INT NULL,
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Trống'
        CHECK (TrangThai IN (N'Trống', N'Đã đặt', N'Đang sử dụng', N'Bảo trì')),
    TinhTrangVeSinh NVARCHAR(20) NOT NULL DEFAULT N'Sạch'
        CHECK (TinhTrangVeSinh IN (N'Sạch', N'Chưa dọn', N'Đang dọn')),
    GhiChu NVARCHAR(500) NULL,
    CONSTRAINT FK_PHONG_LOAIPHONG FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LOAIPHONG(MaLoaiPhong)
);

CREATE INDEX IX_PHONG_TrangThai ON dbo.PHONG(TrangThai);
CREATE INDEX IX_PHONG_Tang ON dbo.PHONG(Tang);
CREATE INDEX IX_PHONG_Loai ON dbo.PHONG(MaLoaiPhong);

-- ==================== 6) DỊCH VỤ ====================
CREATE TABLE dbo.DICHVU (
    MaDV VARCHAR(10) PRIMARY KEY,
    TenDV NVARCHAR(50) NOT NULL,
    LoaiDV NVARCHAR(30) NULL CHECK (LoaiDV IN (N'Ăn uống', N'Giặt ủi', N'Spa', N'Minibar', N'Khác')),
    DonGia INT NOT NULL CHECK (DonGia > 0),
    DVT NVARCHAR(20) NULL,
    TrangThai BIT NOT NULL DEFAULT 1
);

-- ==================== 7) ĐẶT PHÒNG ====================
CREATE TABLE dbo.DATPHONG (
    MaDatPhong VARCHAR(10) PRIMARY KEY,
    MaKH VARCHAR(10) NOT NULL,
    MaNV VARCHAR(10) NOT NULL,
    NgayDat DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    TienCoc INT NOT NULL DEFAULT 0 CHECK (TienCoc >= 0),
    GhiChu NVARCHAR(500) NULL,
    CONSTRAINT FK_DATPHONG_KHACHHANG FOREIGN KEY (MaKH) REFERENCES dbo.KHACHHANG(MaKH),
    CONSTRAINT FK_DATPHONG_NHANVIEN FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN(MaNV)
);

CREATE INDEX IX_DATPHONG_NgayDat ON dbo.DATPHONG(NgayDat);
CREATE INDEX IX_DATPHONG_MaKH ON dbo.DATPHONG(MaKH);

-- ==================== 8) CHI TIẾT ĐẶT PHÒNG ====================
CREATE TABLE dbo.CHITIET_DATPHONG (
    MaCTDP VARCHAR(15) PRIMARY KEY,
    MaDatPhong VARCHAR(10) NOT NULL,
    MaPhong VARCHAR(10) NOT NULL,
    NgayNhanDuKien DATETIME NOT NULL,
    NgayTraDuKien DATETIME NOT NULL,
    NgayNhanThucTe DATETIME NULL,
    NgayTraThucTe DATETIME NULL,
    DonGiaTaiThoiDiemDat INT NOT NULL CHECK (DonGiaTaiThoiDiemDat > 0),
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đã đặt'
        CHECK (TrangThai IN (N'Đã đặt', N'Đang sử dụng', N'Đã trả', N'Đã hủy')),
    GhiChu NVARCHAR(500) NULL,
    CONSTRAINT FK_CTDP_DATPHONG FOREIGN KEY (MaDatPhong) REFERENCES dbo.DATPHONG(MaDatPhong),
    CONSTRAINT FK_CTDP_PHONG FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
    CONSTRAINT CHK_CTDP_NgayThang CHECK (
        NgayTraDuKien > NgayNhanDuKien
        AND (NgayNhanThucTe IS NULL OR NgayTraThucTe IS NULL OR NgayTraThucTe >= NgayNhanThucTe)
    )
);

CREATE INDEX IX_CTDP_NgayNhanTra ON dbo.CHITIET_DATPHONG(NgayNhanDuKien, NgayTraDuKien);
CREATE INDEX IX_CTDP_TrangThai ON dbo.CHITIET_DATPHONG(TrangThai);
CREATE INDEX IX_CTDP_MaPhong ON dbo.CHITIET_DATPHONG(MaPhong);

-- ==================== 9) HÓA ĐƠN ====================
-- Không còn cột computed TongTienTruocThue / TongTienSauThue
CREATE TABLE dbo.HOADON (
    MaHD VARCHAR(10) PRIMARY KEY,
    MaDatPhong VARCHAR(10) NOT NULL,
    MaNV VARCHAR(10) NOT NULL,
    NgayLap DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    TongTienPhong INT NOT NULL DEFAULT 0 CHECK (TongTienPhong >= 0),
    TongTienDichVu INT NOT NULL DEFAULT 0 CHECK (TongTienDichVu >= 0),
    PhuPhi INT NOT NULL DEFAULT 0 CHECK (PhuPhi >= 0),
    GiamGia INT NOT NULL DEFAULT 0 CHECK (GiamGia >= 0),
    ThueVAT INT NOT NULL DEFAULT 10 CHECK (ThueVAT >= 0),

    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Chưa thanh toán'
        CHECK (TrangThai IN (N'Chưa thanh toán', N'Đã thanh toán', N'Đã hủy')),

    PhuongThucTT NVARCHAR(30) NULL
        CHECK (PhuongThucTT IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ', N'Khác')),

    GhiChu NVARCHAR(500) NULL,

    CONSTRAINT FK_HOADON_DATPHONG FOREIGN KEY (MaDatPhong) REFERENCES dbo.DATPHONG(MaDatPhong),
    CONSTRAINT FK_HOADON_NHANVIEN FOREIGN KEY (MaNV) REFERENCES dbo.NHANVIEN(MaNV)
);

CREATE INDEX IX_HOADON_NgayLap ON dbo.HOADON(NgayLap);
CREATE INDEX IX_HOADON_TrangThai ON dbo.HOADON(TrangThai);
CREATE INDEX IX_HOADON_MaDatPhong ON dbo.HOADON(MaDatPhong);

-- ==================== 10) CHI TIẾT DỊCH VỤ ====================
-- Không còn cột computed ThanhTien
-- Nếu muốn lưu ThanhTien cho tiện hiển thị/report, giữ cột thường ThanhTien INT và C# tự set
CREATE TABLE dbo.CHITIET_DICHVU (
    MaCTDV VARCHAR(15) PRIMARY KEY,
    MaHD VARCHAR(10) NOT NULL,
    MaDV VARCHAR(10) NOT NULL,
    MaPhong VARCHAR(10) NOT NULL,
    NgaySuDung DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,

    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia INT NOT NULL CHECK (DonGia >= 0),
    ThanhTien INT NOT NULL DEFAULT 0 CHECK (ThanhTien >= 0),

    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đã order'
        CHECK (TrangThai IN (N'Đã order', N'Hoàn thành', N'Đã hủy')),

    GhiChu NVARCHAR(200) NULL,

    CONSTRAINT FK_CTDV_HOADON FOREIGN KEY (MaHD) REFERENCES dbo.HOADON(MaHD),
    CONSTRAINT FK_CTDV_DICHVU FOREIGN KEY (MaDV) REFERENCES dbo.DICHVU(MaDV),
    CONSTRAINT FK_CTDV_PHONG FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong)
);

CREATE INDEX IX_CTDV_NgaySuDung ON dbo.CHITIET_DICHVU(NgaySuDung);
CREATE INDEX IX_CTDV_MaPhong ON dbo.CHITIET_DICHVU(MaPhong);
CREATE INDEX IX_CTDV_MaHD ON dbo.CHITIET_DICHVU(MaHD);
