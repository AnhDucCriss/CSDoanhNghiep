using DuAn2.Data;

namespace DuAn2.Interface
{
    public interface IMonHoc
    {
        public Task<List<MonHoc>> getAllMonHoc();
        public Task<MonHoc> getMonHocById(string id);
        public Task<string> themMonHoc(MonHoc model);
        public Task suaMonHoc(string id, MonHoc model);
        public Task xoaMonHoc(string id);
    }

}
