using Microsoft.EntityFrameworkCore;
using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public class MonHocRepository : IMonHocRepository
    {
        private readonly WebContext _context;

        public MonHocRepository(WebContext context) 
        {
            _context = context;
        }
        public async Task<List<MonHoc>> getAllMonHoc()
        {
            var mhs = await _context.monHocs!.ToListAsync();
            return mhs;
        }

        public async Task<MonHoc> getMonHocById(string id)
        {
            var mh = await _context.monHocs!.FindAsync(id);
            return mh;
        }

        public async Task suaMonHoc(string id, MonHoc model)
        {
            if(id == model.Id)
            {
                _context.monHocs!.Update(model);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<string> themMonHoc(MonHoc model)
        {
            _context.monHocs!.Add(model);
            await _context.SaveChangesAsync();
            return model.Id;
        }

        public async Task xoaMonHoc(string id)
        {
            var delMH = _context.monHocs!.SingleOrDefault(x => x.Id == id);
            if(delMH != null)
            {   
                _context.monHocs!.Remove(delMH);
                await _context.SaveChangesAsync();
            }
        }
    }
}
