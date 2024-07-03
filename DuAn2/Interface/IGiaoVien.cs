using DuAn2.Data;

namespace DuAn2.Interface
{
    public interface IGiaoVien
    {
        public List<GiaoVien> getAllGiaoVien(string ma, string search, int page = 1);
        public Task<string> themGiaoVien(GiaoVien model);
        public Task xoaGiaVien(string id);
    }
}
