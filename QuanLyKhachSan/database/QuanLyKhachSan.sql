-- 1) BỘ PHẬN
CREATE TABLE BOPHAN (
    MaBP VARCHAR(10) PRIMARY KEY,
    TenBP NVARCHAR(50) UNIQUE NOT NULL
);

-- 2) NHÂN VIÊN
CREATE TABLE NHANVIEN (
    MaNV VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    CCCD VARCHAR(12) UNIQUE,
    DiaChi NVARCHAR(100),
    DienThoai VARCHAR(15) UNIQUE,
    MatKhau VARCHAR(100),
    MaBP VARCHAR(10),
    Email VARCHAR(50),
    NgayVaoLam DATE,
    Luong INT CHECK (Luong >= 0),
    Quyen VARCHAR(20) CHECK (Quyen IN ('Admin', 'QuanLy', 'LeTan')),
    TrangThai BIT DEFAULT 1,
    FOREIGN KEY (MaBP) REFERENCES BOPHAN(MaBP)
);

-- 3) KHÁCH HÀNG
CREATE TABLE KHACHHANG (
    MaKH VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    CCCD VARCHAR(12),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10) CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    DiaChi NVARCHAR(100),
    DienThoai VARCHAR(15),
    Email VARCHAR(50),
    QuocTich NVARCHAR(30) DEFAULT N'Việt Nam',
    LoaiKH NVARCHAR(20) CHECK (LoaiKH IN (N'Cá nhân', N'Tổ chức')),
    NgayDangKy DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- 4) NHÀ CUNG CẤP
CREATE TABLE NHACUNGCAP (
    MaNCC VARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    DienThoai VARCHAR(15),
    Email VARCHAR(50),
    NguoiDaiDien NVARCHAR(50),
    MaSoThue VARCHAR(20),
    LoaiNCC NVARCHAR(30) CHECK (LoaiNCC IN (N'Tiện nghi', N'Dịch vụ', N'Vật tư', N'Thực phẩm')),
    TrangThai BIT DEFAULT 1,
    NgayHopTac DATE,
    GhiChu NVARCHAR(200)
);

-- 5) LOẠI PHÒNG
CREATE TABLE LOAIPHONG (
    MaLoaiPhong VARCHAR(10) PRIMARY KEY,
    TenLoaiPhong NVARCHAR(50) NOT NULL,
    DonGia INT NOT NULL CHECK (DonGia > 0),
    SoNguoi INT CHECK (SoNguoi > 0),
    SoGiuong INT CHECK (SoGiuong > 0)
);

-- 6) PHÒNG
CREATE TABLE PHONG (
    MaPhong VARCHAR(10) PRIMARY KEY,
    MaLoaiPhong VARCHAR(10),
    TenPhong NVARCHAR(30) NOT NULL,
    Tang INT CHECK (Tang > 0),
    TrangThai NVARCHAR(20) DEFAULT N'Trống' 
        CHECK (TrangThai IN (N'Trống', N'Đã đặt', N'Đang sử dụng', N'Bảo trì')),
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaLoaiPhong) REFERENCES LOAIPHONG(MaLoaiPhong)
);

-- 7) TIỆN NGHI
CREATE TABLE TIENNGHI (
    MaTienNghi VARCHAR(10) PRIMARY KEY,
    TenTienNghi NVARCHAR(50) NOT NULL,
    SoLuongTong INT CHECK (SoLuongTong >= 0),
    GiaTri INT CHECK (GiaTri >= 0),
    TinhTrang NVARCHAR(20) CHECK (TinhTrang IN (N'Tốt', N'Cần bảo trì', N'Hỏng')),
    NhaCungCap NVARCHAR(100),
    NgayNhap DATE,
    MoTa NVARCHAR(200)
);
-- 8) PHÒNG - TIỆN NGHI
CREATE TABLE PHONG_TIENNGHI (
    MaPhong VARCHAR(10),
    MaTienNghi VARCHAR(10),
    SoLuong INT DEFAULT 1 CHECK (SoLuong > 0),
    NgayLapDat DATE,
    TinhTrang NVARCHAR(20) CHECK (TinhTrang IN (N'Tốt', N'Cần bảo trì', N'Hỏng')),
    PRIMARY KEY (MaPhong, MaTienNghi),
    FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong),
    FOREIGN KEY (MaTienNghi) REFERENCES TIENNGHI(MaTienNghi)
);

-- 9) DỊCH VỤ
CREATE TABLE DICHVU (
    MaDV VARCHAR(10) PRIMARY KEY,
    TenDV NVARCHAR(50) NOT NULL,
    LoaiDV NVARCHAR(30) CHECK (LoaiDV IN (N'Ăn uống', N'Giặt ủi', N'Spa', N'Minibar')),
    DonGia INT NOT NULL CHECK (DonGia > 0),
    DVT NVARCHAR(20) CHECK (DVT IN (N'Suất', N'Lần', N'Chai', N'Lon')),
    NhaCungCap NVARCHAR(100),
    KhuyenMai INT DEFAULT 0 CHECK (KhuyenMai BETWEEN 0 AND 100),
    TrangThai BIT DEFAULT 1,
    MoTa NVARCHAR(200)
);

-- 10) ĐẶT PHÒNG
CREATE TABLE DATPHONG (
    MaDatPhong VARCHAR(10) PRIMARY KEY,
    MaKH VARCHAR(10),
    MaNV VARCHAR(10),
    NgayDat DATETIME DEFAULT CURRENT_TIMESTAMP,
    NgayNhanPhong DATETIME NOT NULL,
    NgayTraPhong DATETIME NOT NULL,
    SoNguoi INT CHECK (SoNguoi > 0),
    TienCoc INT CHECK (TienCoc >= 0),
    TrangThai NVARCHAR(20) DEFAULT N'Đã đặt' 
        CHECK (TrangThai IN (N'Đã đặt', N'Đã nhận phòng', N'Đã trả phòng', N'Đã hủy')),
    LyDoHuy NVARCHAR(200),
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaKH) REFERENCES KHACHHANG(MaKH),
    FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV),
    CHECK (NgayTraPhong > NgayNhanPhong)
);

-- 11) CHI TIẾT ĐẶT PHÒNG
CREATE TABLE CHITIET_DATPHONG (
    MaDatPhong VARCHAR(10),
    MaPhong VARCHAR(10),
    NgayNhan DATETIME,
    NgayTra DATETIME,
    DonGia INT CHECK (DonGia >= 0),
    SoNguoi INT CHECK (SoNguoi > 0),
    GhiChu NVARCHAR(200),
    PRIMARY KEY (MaDatPhong, MaPhong),
    FOREIGN KEY (MaDatPhong) REFERENCES DATPHONG(MaDatPhong),
    FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong),
    CHECK (NgayTra > NgayNhan)
);

-- 12) HÓA ĐƠN
CREATE TABLE HOADON (
    MaHD VARCHAR(10) PRIMARY KEY,
    MaDatPhong VARCHAR(10),
    MaNV VARCHAR(10),
    NgayLap DATETIME DEFAULT CURRENT_TIMESTAMP,
    TongTienPhong INT CHECK (TongTienPhong >= 0),
    TongTienDichVu INT CHECK (TongTienDichVu >= 0),
    TienCoc INT CHECK (TienCoc >= 0),
    GiamGia INT DEFAULT 0 CHECK (GiamGia >= 0),
    TongTien INT CHECK (TongTien >= 0),
    TrangThai NVARCHAR(20) DEFAULT N'Chưa thanh toán' 
        CHECK (TrangThai IN (N'Chưa thanh toán', N'Đã thanh toán')),
    PhuongThucTT NVARCHAR(30) CHECK (PhuongThucTT IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ')),
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaDatPhong) REFERENCES DATPHONG(MaDatPhong),
    FOREIGN KEY (MaNV) REFERENCES NHANVIEN(MaNV)
);

-- 13) CHI TIẾT HÓA ĐƠN (Bảng mới - chi tiết từng dòng trong hóa đơn)
CREATE TABLE CHITIET_HOADON (
    MaHD VARCHAR(10),
    STT INT,
LoaiChiPhi NVARCHAR(20) CHECK (LoaiChiPhi IN (N'Phòng', N'Dịch vụ')),
    MaPhong VARCHAR(10) NULL,           -- Có giá trị nếu là tiền phòng
    MaDV VARCHAR(10) NULL,              -- Có giá trị nếu là tiền dịch vụ
    TenMucPhi NVARCHAR(100) NOT NULL,   -- VD: "Phòng 101 (3 ngày)", "Dịch vụ Spa"
    NgayBatDau DATETIME NULL,           -- Ngày bắt đầu (cho phòng)
    NgayKetThuc DATETIME NULL,          -- Ngày kết thúc (cho phòng)
    SoLuong INT CHECK (SoLuong > 0),    -- Số đêm (phòng) hoặc số lượng (dịch vụ)
    DonGia INT CHECK (DonGia >= 0),
    GiamGia INT DEFAULT 0 CHECK (GiamGia >= 0),
    ThanhTien INT CHECK (ThanhTien >= 0),
    GhiChu NVARCHAR(200),
    PRIMARY KEY (MaHD, STT),
    FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),
    FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong),
    FOREIGN KEY (MaDV) REFERENCES DICHVU(MaDV),
    -- Ràng buộc: Nếu là Phòng thì phải có MaPhong, nếu là Dịch vụ thì phải có MaDV
    CHECK (
        (LoaiChiPhi = N'Phòng' AND MaPhong IS NOT NULL AND MaDV IS NULL) OR
        (LoaiChiPhi = N'Dịch vụ' AND MaDV IS NOT NULL AND MaPhong IS NULL)
    )
);

-- 14) CHI TIẾT DỊCH VỤ (Giữ lại để tracking chi tiết sử dụng dịch vụ)
CREATE TABLE CHITIET_DICHVU (
    MaHD VARCHAR(10),
    MaDV VARCHAR(10),
    NgaySuDung DATETIME DEFAULT CURRENT_TIMESTAMP,
    SoLuong INT CHECK (SoLuong > 0),
    DonGia INT CHECK (DonGia >= 0),
    GiamGia INT DEFAULT 0 CHECK (GiamGia >= 0),
    ThanhTien INT CHECK (ThanhTien >= 0),
    GhiChu NVARCHAR(200),
    PRIMARY KEY (MaHD, MaDV, NgaySuDung),
    FOREIGN KEY (MaHD) REFERENCES HOADON(MaHD),
    FOREIGN KEY (MaDV) REFERENCES DICHVU(MaDV)
);