using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn2.Data
{
    public class TKB
    {
        [Key]
        [MaxLength(40)]
        public string Id { get; set; }
        public string IdLichHoc { get; set; }
        public DayOfWeek Thu { get; set; }
        public DateTime NgayHoc { get; set; }
        public string? TietHoc { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public string?  TrangThai { get; set; }
        public string IdLopHoc { get; set; }
    }
    public class ThoiDiem
    {
        public string Id { get; set; }
        public DateTime value { get; set; }
        public List<LichTKB> ListLichTKB { get; set; } = new List<LichTKB>();
       
    }
    public class LichTKB
    {
        [Key]
        [MaxLength(40)]
        public string Id { get; set; }
        public DayOfWeek Thu { get; set; }
        public DateTime ThoiGian { get; set; }
        public string? Confirm { get; set; }
    }


}
