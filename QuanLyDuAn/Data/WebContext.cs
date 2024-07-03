using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAn.Data
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> opt) : base(opt) { 
        }

        #region
        public DbSet<DungCu>? dungCus { get; set; }
        public DbSet<PhongHoc>? phongHocs { get; set; }
        public DbSet<PhongHoc_DungCu>? phongHoc_DungCus { get; set; }
        public DbSet<MonHoc>? monHocs { get; set; } 
        public DbSet<TrinhDo>? trinhDos { get; set; }
        public DbSet<GiaoVien>? giaoViens { get; set; }
        #endregion


    }
}
