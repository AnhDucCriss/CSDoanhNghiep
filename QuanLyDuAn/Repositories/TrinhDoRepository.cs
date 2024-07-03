using Microsoft.EntityFrameworkCore;
using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public class TrinhDoRepository : ITrinhDoRepository
    {
        private readonly WebContext _context;

        public TrinhDoRepository(WebContext context) 
        { 
            _context = context;
        }
        public Task<List<TrinhDo>> getAllTrinhDo()
        {
            var tds = _context.trinhDos!.ToListAsync();
            return tds;
        }

        
        public async Task<TrinhDo> getTrinhDoByID(string id)
        {
            var td = await _context.trinhDos!.FindAsync(id);
            return td;
        }

        public async Task suaTrinhDo(string id, TrinhDo model)
        {
            if(id == model.Id)
            {
                _context.trinhDos!.Update(model);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<string> themTrinhDo(TrinhDo model)
        {
            _context.trinhDos!.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task xoaTrinhDo(string id)
        {
            var delTD = _context.trinhDos!.SingleOrDefault(x => x.Id == id);
            if(delTD != null)
            {
                _context.trinhDos!.Remove(delTD);
                await _context.SaveChangesAsync();
            }
        }
    }
}
