using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.EntityFrameworkCore;

namespace DuAn2.Repositories
{
    public class MonHocRepository : IMonHoc

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
            if (id == model.Id)
            {
                _context.monHocs!.Update(model);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<string> themMonHoc(MonHoc model)
        {
            MonHoc monHoc = await _context.monHocs.FirstOrDefaultAsync(x => x.Id == model.Id && x.Id != model.Id);
            if (monHoc != null) return "Đã tồn tại môn học";
            if (string.IsNullOrEmpty(model.Id))
            {
                model.Id = Guid.NewGuid().ToString();
                _context.Add(model);
            }
            else
            {
                _context.Update(model);
            }
            _context.SaveChanges();
            return "Thêm môn học thành công";
        }

        public async Task xoaMonHoc(string id)
        {
            var delMH = _context.monHocs!.SingleOrDefault(x => x.Id == id);
            if (delMH != null)
            {
                _context.monHocs!.Remove(delMH);
                await _context.SaveChangesAsync();
            }
        }
    }
}
