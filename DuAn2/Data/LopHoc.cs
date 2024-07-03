using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn2.Data
{
    public class LopHoc
    {
        public string Id { get; set; }
        public string MaLop { get; set; }
        public string IdPhongHoc { get; set; }
        public string IdGiaoVien { get; set; }
        public string IdMonHoc { get; set; }
        public string TietHoc { get; set; } 
        public string TrangThai { get; set; }
      
        [NotMapped]
        public List<LopHocVien> ListLopHocVien { get; set; }
        [NotMapped]
        public List<LichHoc> ListLichHoc { get; set; }

    }
}
