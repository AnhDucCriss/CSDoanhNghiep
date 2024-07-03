using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Data
{
    public class MonHoc
    {
        [Key]
        public string Id { get; set; }
        public string tenMonHoc { get; set; }
        public string? ghiChu { get; set; }
    }
}
