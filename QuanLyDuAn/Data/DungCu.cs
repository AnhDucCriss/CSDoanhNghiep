using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Data
{
    public class DungCu
    {
        [Key]
        public string Id { get; set; }
        public string tenDungCu { get; set; }
        public string? ghiChu { get; set; }
        
        
    }

}
