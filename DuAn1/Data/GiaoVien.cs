using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn1.Data
{
    public class GiaoVien
    {
        [Key]
        [StringLength(50)]
        public string Id { get; set; }
        public string tenGiaoVien { get; set; }
        public string gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string cccd { get; set; }
        public string IdTrinhDo { get; set; }
        public int soDienThoai { get; set; }
        public string email { get; set; }
        public string diaChi { get; set; }
        public int soTaiKhoan { get; set; }
        public string nganHang { get; set; }
        public string maThue { get; set; }
        public string trangThai { get; set; }
        [NotMapped]
        public List<MucTienCong> listTienCong { get; set; }
        [NotMapped]
        public List<LichDay> listLichDay { get; set; }
    } 
}
