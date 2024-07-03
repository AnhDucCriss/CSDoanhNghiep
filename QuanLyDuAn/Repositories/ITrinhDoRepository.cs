using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public interface ITrinhDoRepository
    {
        public Task<List<TrinhDo>> getAllTrinhDo();
        public Task<TrinhDo> getTrinhDoByID(string id);

        public Task<string> themTrinhDo(TrinhDo model);
        public Task suaTrinhDo(string id, TrinhDo model);
        public Task xoaTrinhDo(string id);

    }
}
