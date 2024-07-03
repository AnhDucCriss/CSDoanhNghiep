using Microsoft.EntityFrameworkCore;

namespace DuAn1.Data
{
    public class WebContext : DbContext
    {
        public WebContext(DbContextOptions<WebContext> opt) : base(opt)
        {
        }

        #region
       
        public DbSet<GiaoVien>? giaoViens { get; set; }
        public DbSet<MucTienCong>? mucTienCongs { get; set; }
        public DbSet<LichDay>? lichDays { get; set; }
        #endregion
    }
}
