using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class LibraryContext : DbContext
    {
        // ✅ Các DbSet tương ứng với các bảng trong database
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Publisher> Publishers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Borrowbooks> Borrowbooks { get; set; } = null!;

        // 🆕 Thêm mới 2 bảng CheckIn và PointsLedger
        public DbSet<CheckIn> CheckIns { get; set; } = null!;
        public DbSet<PointsLedger> PointsLedgers { get; set; } = null!;

        // ✅ Cấu hình chuỗi kết nối
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=LAPTOP-6IETI6BT\\TESTDB;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True"
                );
            }
        }

        // ✅ Cấu hình mối quan hệ và bảng
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🔹 Category – Book: 1-nhiều
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔹 Publisher – Book: 1-nhiều
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId)
                .OnDelete(DeleteBehavior.SetNull);

            // 🔹 User – Borrowbooks: 1-nhiều
            modelBuilder.Entity<Borrowbooks>()
                .HasOne(b => b.User)
                .WithMany(u => u.Borrowbooks)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // 🔹 Book – Borrowbooks: 1-nhiều
            modelBuilder.Entity<Borrowbooks>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.Borrowbooks)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Cascade);

            // User – CheckIn: cho phép cascade
            modelBuilder.Entity<CheckIn>()
                .HasOne(c => c.User)
                .WithMany(u => u.CheckIns)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User – PointsLedger: KHÔNG cascade (tránh multiple cascade paths)
            modelBuilder.Entity<PointsLedger>()
                .HasOne(p => p.User)
                .WithMany(u => u.PointsLedgers)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict); // hoặc .OnDelete(DeleteBehavior.NoAction);

            // PointsLedger – CheckIn: nếu có liên kết, không cascade
            modelBuilder.Entity<PointsLedger>()
                .HasOne(p => p.CheckIn)
                .WithMany()
                .HasForeignKey(p => p.CheckInId)
                .OnDelete(DeleteBehavior.SetNull);
            

            // ✅ Đặt tên bảng rõ ràng
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Publisher>().ToTable("Publishers");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Borrowbooks>().ToTable("Borrowbooks");
            modelBuilder.Entity<CheckIn>().ToTable("CheckIns");
            modelBuilder.Entity<PointsLedger>().ToTable("PointsLedger");

            // 🧩 Tạo index để tối ưu truy vấn thống kê
            modelBuilder.Entity<CheckIn>()
                .HasIndex(x => new { x.UserId, x.CheckInTime });

            modelBuilder.Entity<PointsLedger>()
                .HasIndex(x => new { x.UserId, x.CreatedAt });
        }
    }
}
