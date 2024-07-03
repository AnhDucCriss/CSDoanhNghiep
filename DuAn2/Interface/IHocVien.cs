using DuAn2.Data;

namespace DuAn2.Interface
{
    public interface IHocVien
    {
        public List<HocVien> getAllHocVien(string ma, string ten,int page =1);
        public Task<string> themHocVien(HocVien hocVien);
        public Task xoaHocVien(string id);
    }
}
