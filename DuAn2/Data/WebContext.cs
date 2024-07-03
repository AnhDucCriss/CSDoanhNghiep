using Microsoft.EntityFrameworkCore;


namespace DuAn2.Data
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> opt) : base(opt)
        {
        }

        #region
       
        public DbSet<GiaoVien>? giaoViens { get; set; }
        public DbSet<MonHoc>? monHocs { get; set; }
        public DbSet<MucTienCong>? mucTienCongs { get; set; }
        public DbSet<LichDay>? lichDays { get; set; }
        public DbSet<HocVien>? hocViens { get; set; }
        public DbSet<TimeSlot>? timeSlots { get; set; }
        public DbSet<KhungGio>? khungGios { get; set; }
        public DbSet<LopHoc>? lopHocs { get; set; }
        public DbSet<LopHocVien>? lopHocViens { get; set; }
        public DbSet<LichHoc>? lichHocs { get; set; }
        public DbSet<TKB>? TKBs { get; set; }
        public DbSet<LichTKB>? lichTKBs { get; set; }
        public DbSet<ThoiDiem>? thoiDiems { get; set; }
        public DbSet<DungCu>? dungCus { get; set; }
        public DbSet<TrinhDo>? trinhDos { get; set; }
        public DbSet<PhongHoc>? phongHocs { get; set; }
        public DbSet<PhongHoc_DungCu>? phongHoc_DungCus { get; set; }
        #endregion
    }
}
