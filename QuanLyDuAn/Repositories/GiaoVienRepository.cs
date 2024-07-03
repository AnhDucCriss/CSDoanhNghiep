using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyDuAn.Data;

namespace QuanLyDuAn.Repositories
{
    public class GiaoVienRepository : IGiaoVienRepository
    {
        private readonly WebContext _context;

        public GiaoVienRepository(WebContext context) 
        { 
            _context = context;
        }
        public async Task<List<GiaoVien>> getAllGiaoVien()
        {
            var gvs = await _context.giaoViens!.ToListAsync();
            return gvs;
        }

        public async Task<GiaoVien> getGiaoVienById(string Id)
        {
            var gv = await _context.giaoViens!.FindAsync(Id);
            return gv;
        }

        public async Task suaGiaoVien(string id, GiaoVien model)
        {
            if(id == model.Id)
            {
                _context.giaoViens!.Update(model);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<string> themGiaoVien(GiaoVien model)
        {
            
            _context.giaoViens!.Add(model);
            await _context.SaveChangesAsync();

            return model.Id;
        }

        public async Task xoaGiaVien(string id)
        {
            var delGV = _context.giaoViens!.SingleOrDefault(x => x.Id == id);
            if (delGV != null)
            {
                _context.giaoViens!.Remove(delGV);
                await _context.SaveChangesAsync();

            }
        }
    }
}
