using DuAn1.Data;

namespace DuAn1.Interface
{
    public interface IGiaoVien
    {
        public Task<List<GiaoVien>> getAllGiaoVien();
        public Task<GiaoVien> getGiaoVienById(string Id);
        public Task<string> themGiaoVien(GiaoVien model);
        public Task suaGiaoVien(string id, GiaoVien model);
        public Task xoaGiaVien(string id);
    }
}
