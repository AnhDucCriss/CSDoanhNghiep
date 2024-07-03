using System.ComponentModel.DataAnnotations;

namespace DuAn2.Data
{
    public class MonHoc
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        public string tenMonHoc { get; set; }
        public string? ghiChu { get; set; }
    }
}
