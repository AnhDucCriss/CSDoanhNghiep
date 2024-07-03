using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public interface IPhongHocRepository
    {
        public Task<List<PhongHoc>> getAllPhongHoc();
        public Task<PhongHoc> getPhongHocById(string id);
        public Task<string> themPhongHoc(PhongHoc model);
        
        public Task suaPhongHoc(string id, PhongHoc model);
        public Task xoaPhongHoc(string id);
    }
}
