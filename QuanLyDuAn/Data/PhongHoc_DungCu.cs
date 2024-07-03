using System.ComponentModel.DataAnnotations;

namespace QuanLyDuAn.Data
{
    public class PhongHoc_DungCu
    {
        [Key]
        public string Id { get; set; }
        public string PhongHocId { get; set; }//khoa phu bang phòng học
        
        public string DungCuId { get; set; }//khóa phụ bảng dụng cụ
    }
}
