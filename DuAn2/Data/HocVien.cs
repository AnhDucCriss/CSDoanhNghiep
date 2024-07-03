using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn2.Data
{
    public class HocVien
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; }
        public string? maHocVien { get; set; }
        public string?  IdLopHoc { get; set; }
        public string? tenHocVien { get; set; }
        public string? gioiTinh { get; set; }
        public DateTime? ngaySinh { get; set; }
        public string? soDT { get; set; }
        public string? email { get; set; }
        public string? diaChi { get; set; }
        public string? trangThai { get; set; }
        public string? tenCha { get; set; }
        public string? soDTCha { get; set; }
        public string? emailCha { get; set; }
        public string? ghiChuCha { get; set; }
        public string? tenMe { get; set; }
        public string? soDTMe { get; set; }
        public string? emailMe { get; set; }
        public string? ghiChuMe { get; set; }
        

    }
    public class LopHocVien
    {
        [Key]
        [MaxLength(36)]
        public string Id { get; set; }
        [MaxLength(36)]
        public string? IdLop { get; set; }
        public HocVien HocVien { get; set; }
       
    }
}
