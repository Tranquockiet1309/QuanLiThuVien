# Hệ thống Quản lý Thư viện (Library Management System)

Một ứng dụng Desktop quản lý thư viện hiện đại được xây dựng hoàn toàn bằng **C# .NET 8 (Windows Forms)** kết hợp với **Entity Framework Core**. Hệ thống tập trung tối ưu hóa trải nghiệm người dùng với giao diện phẳng (Flat UI), đồng thời áp dụng kiến trúc **N-Tier (N-Lớp)** để code sạch sẽ, dễ bảo trì và mở rộng. Dự án được triển khai bởi sinh viên Trần Quốc Kiệt (MSSV: 2123110364).

---

## 📸 Ảnh minh họa giao diện (Screenshots)

| Dashboard - Tổng quan |
<img width="1919" height="1021" alt="image" src="https://github.com/user-attachments/assets/13929c1e-81f1-405e-9551-fda8100c0d96" />
| Danh sách Sách |
<img width="1918" height="1018" alt="image" src="https://github.com/user-attachments/assets/6e212616-85f9-4d2c-91b3-f3c542785273" />


---

## 🌟 Chức năng nổi bật (Features)

*   **Quản lý người dùng:** Phân quyền thông minh (Admin, Reader). Xem, kiểm soát nhân sự hệ thống và độc giả. 
*   **Danh mục sách & ấn phẩm:** Thêm, sửa, xóa, tìm kiếm sách/đầu sách theo thể loại, theo Nhà xuất bản.
*   **Nghiệp vụ mượn - trả sách:** Xử lý logic vòng đời mượn thư viện chặt chẽ. Cảnh báo đối tượng đang giữ sách chưa trả, chặn thao tác rác.
*   **Hệ thống Check-in & Nhật ký điểm (Ledger):** Ghi chú các lần tới thư viện, cộng trừ tự động điểm rèn luyện dựa vào các thao tác hoạt động.
*   **Thống kê Dashboard hiện đại:** Biểu đồ hiển thị nhanh trực quan số lượng sách, số lượng nhân viên, số lượt thủ tục... (Render theo phong cách phẳng Material Design chuẩn Tailwind CSS).

---

## 🏗 Kiến trúc dự án (Architecture)

Khác với các ứng dụng WinForms cơ bản, hệ thống này được tuân thủ nghiêm ngặt mô hình **N-Tier** với 4 Project độc lập (chia để trị):

1.  **`Data` (Data Access Layer):** Chứa các Model ánh xạ vào Entity (Book, User, Category...) và `LibraryContext`. Cấu hình Fluent API chặt chẽ, tự động sinh cơ sở dữ liệu qua Migrations với MS SQL Server.
2.  **`DTO` (Data Transfer Object):** Các cấu trúc dữ liệu nén, siêu nhẹ, dùng để "giao tiếp" trung gian. Bảo vệ cơ sở dữ liệu tránh việc bị phơi bày logic thừa thãi lên màn hình giao diện. 
3.  **`Services` (Business Logic Layer):** Đầu não nghiệp vụ của phần mềm. Xử lý logic như (Cho mượn, Check sách, Cộng điểm). Mọi xử lý đều được tiêu chuẩn hóa theo cấu trúc trả về `ServiceResult` bắt các lỗi an toàn thay vì tung Exception.
4.  **`UI` (Presentation Layer):** Tầng giao diện người dùng trơn tru, hiện đại. Được tích hợp `ThemeManager.cs` giúp thao tác tự động render đồng nhất màu nền, flat buttons, dgv flat mà không cần cài thêm framework UI bên ngoài.

---

## 💻 Công nghệ sử dụng (Technologies)

*   **Ngôn ngữ lập trình:** C#
*   **Framework:** .NET 8 (Windows Forms)
*   **Cơ sở dữ liệu:** Microsoft SQL Server
*   **ORM (Object-Relational Mapping):** Entity Framework Core (Code-First Approach)
*   **Tiện ích:**
    *   `ClosedXML`: Hỗ trợ xử lý xuất/nhập xuất báo cáo định dạng file Excel.

---

## 🚀 Hướng dẫn cài đặt & Chạy dự án (Installation)

### 1. Yêu cầu hệ thống
*   Đã cài đặt [Visual Studio 2022](https://visualstudio.microsoft.com/)
*   Đã cài đặt [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
*   Đã cài đặt **Microsoft SQL Server**

### 2. Sửa lại chuỗi kết nối Database (Connection String)
Chuỗi kết nối với SQL Server đang dùng biến môi trường. Bạn vào file thư mục **`Data/LibraryContext.cs`**, tìm đến phương thức `OnConfiguring`.
Sửa lại chuỗi kết nối sau cho đúng với Name Server của bạn:
```csharp
optionsBuilder.UseSqlServer("Server=TEN\_SERVER\_CUA\_BAN;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True");
```

### 3. Cập nhật Cơ sở dữ liệu (Migrations)
Mở cửa sổ **Package Manager Console** trong Visual Studio (`Tools` > `NuGet Package Manager` > `Package Manager Console`):
*   Chọn Default Project là: **`Data`**
*   Chạy câu lệnh tạo/cập nhật Database tự động:
    ```bash
    Update-Database
    ```

### 4. Build và Chạy (Run Application)
*   Trỏ chuột phải vào Project **`UI`** -> Chọn `Set as Startup Project`.
*   Truy cập Terminal trong thư mục để tự Build nếu cần `dotnet build`.
*   Bấm **F5** (hoặc nút Run xanh trong VS) để cất cánh!

---

## 👥 Tác giả
*   *Trần Quốc Kiệt* (2123110364)
*   *Khóa luận/Bài tập Lập Trình Window*
