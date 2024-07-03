using DuAn1.Data;
using DuAn1.Interface;
using Microsoft.EntityFrameworkCore;

namespace DuAn1.Repositories
{
    public class GiaoVienRepository : IGiaoVien
    {
        private readonly WebContext _context;

        public GiaoVienRepository(WebContext context) { 
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
            if (id == model.Id)
            {
                _context.giaoViens!.Update(model);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<string> themGiaoVien(GiaoVien model)
        {
            GiaoVien giaoVien = await _context.giaoViens!.FirstOrDefaultAsync(x => x.Id == model.Id && x.Id != model.Id);
            if (giaoVien != null) return "Đã tồn tại giáo viên!";
            
           
            if(string.IsNullOrEmpty(model.Id))
            {
                model.Id = Guid.NewGuid().ToString();
                _context.Add(model);
            } else
            {
                _context.Update(model);
            }

            var listTienCong = _context.mucTienCongs.Where(x => x.GiaoVienId == model.Id).ToList();
            _context.RemoveRange(listTienCong);
            if(model.listTienCong != null)
            {
                foreach(var item in model.listTienCong)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.GiaoVienId = model.Id;
                }
                _context.AddRange(listTienCong);
            }
            var listLichDay = _context.lichDays.Where(x => x.GiaoVienId == model.Id).ToList();
            _context.RemoveRange(listLichDay);
            if(model.listLichDay != null)
            {
                foreach(var item in model.listLichDay)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.GiaoVienId = model.Id;
                }
                _context.AddRange(listLichDay);
            }



            _context.SaveChanges();
            return model.Id;
        }

        public async Task xoaGiaVien(string id)
        {
            var delGV = _context.giaoViens!.SingleOrDefault(x => x.Id == id);
            if (delGV != null)
            {
                _context.giaoViens!.Remove(delGV);
                await _context.SaveChangesAsync();

            };
        }
    }
}
