using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn2.Data
{
    public class PhongHoc
    {
        [Key]
        public string Id { get; set; }
        public string tenPhongHoc { get; set; }

        public string? ghiChu { get; set; }
        [NotMapped]
        public List<PhongHoc_DungCu> listDungCu { get; set; }
    }
}
