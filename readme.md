<h2>Ứng dụng Winform Quản lí bãi đỗ xe</h2>

### I. Giới thiệu chung:

- Phát triển ứng dụng Winform Quản lí bãi đỗ xe.
- Môn học: Lập trình huớng đối tượng (OOP).
- Ứng dụng được phát triển bằng ngôn ngữ C# và sử dụng SQL Server để quản lí cơ sở dữ liệu.
- Gồm các tác nhân chính:
  - > Người quản lý: Có thể quản lý chỗ đậu xe và xem các báo cáo khác nhau.
  - > Nhân viên: Có thể hỗ trợ khách hàng đỗ xe và lấy xe.
  - > Khách hàng: Có thể đỗ và lấy xe cũng như xử lý việc thanh toán phí đỗ xe.
- Sử dụng mô hình 3 lớp để phát triển ứng dụng.
  ![Alt text](./Resources/balop.png?raw=true "Title")

### II. Sơ đồ usecase:

![Alt text](./Resources/usecase.png?raw=true "Title")

### III. Database Diagram:

![Alt text](./Resources/data.png?raw=true "Title")

### IV. Các giao diện chính của ứng dụng:

#### 1. Giao diện liên quan đến hệ thống:

- Giao diện đăng nhập:
  ![Alt text](./Resources/DangNhap.png?raw=true "Title")

#### 2. Giao diện liên quan đến người quản lý:

- Giao diện quản lí chỗ đỗ xe:
  ![Alt text](./Resources/aChoDoXe.png?raw=true "Title")
- Giao diện chi tiết chỗ đỗ xe:
  ![Alt text](./Resources/aChiTietChoDoXe.png?raw=true "Title")
- Giao diện quản lí khách hàng:
  ![Alt text](./Resources/aKhachHang.png?raw=true "Title")
- Giao diện chi tiết khách hàng:
  ![Alt text](./Resources/aChiTietKH.png?raw=true "Title")
- Giao diện quản lí nhân viên:
  ![Alt text](./Resources/aNV.png?raw=true "Title")
- Giao diện chi tiết nhân viên:
  ![Alt text](./Resources/aChiTietNV.png?raw=true "Title")
- Giao diện quản lí doanh thu:
  ![Alt text](./Resources/aDoanhThu.png?raw=true "Title")
- Giao diện quản lí tài khoản:
  ![Alt text](./Resources/aTaiKhoan.png?raw=true "Title")
- Giao diện xem và cập nhật thông tin quản lí:
  ![Alt text](./Resources/aCapNhatTHongTin.png?raw=true "Title")

#### 3. Giao diện liên quan đến nhân viên:

- Giao diện xem khách hàng mình được giao:
  ![Alt text](./Resources/cXemKH.png?raw=true "Title")
- Giao diện xem và cập nhật thông tin cá nhân:
  ![Alt text](./Resources/cTHongTIn.png?raw=true "Title")
- Giao diện đổi mật khẩu:
  ![Alt text](./Resources/cDoi.png?raw=true "Title")

#### 4. Giao diện liên quan đến khách hàng:

- Giao diện đỗ xe:
  ![Alt text](./Resources/kDoXe.png?raw=true "Title")
- Giao diện thông tin đỗ xe:
  ![Alt text](./Resources/kThongTInDoXe.png?raw=true "Title")
- Giao diện thanh toán:
  ![Alt text](./Resources/kThanhToan.png?raw=true "Title")
- Giao diện xem và cập nhật thông tin cá nhân:
  ![Alt text](./Resources/kTHongTIn.png?raw=true "Title")
- Giao diện đổi mật khẩu:
  ![Alt text](./Resources/kDoiMK.png?raw=true "Title")
