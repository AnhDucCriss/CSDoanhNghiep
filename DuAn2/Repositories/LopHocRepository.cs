using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAn2.Repositories
{
    public class LopHocRepository : ILopHoc
    {
        private readonly WebContext _context;
        public static int PAGE_SIZE { get; set; } = 3;

        public LopHocRepository(WebContext context) 
        { 
            _context = context;
        }
        public List<LopHoc> GetAllLopHoc(string ma, int page = 1)
        {
            var allLopHoc = _context.lopHocs.AsQueryable();
            if(!string.IsNullOrEmpty(ma))
            {
                allLopHoc = _context.lopHocs.Where(x => x.MaLop.Contains(ma));
            }
            var result = Pagination<LopHoc>.Create(allLopHoc, page, PAGE_SIZE);

            return result.Select(x => new LopHoc
            {
                Id = x.Id,
                MaLop = x.MaLop,
                IdPhongHoc = x.IdPhongHoc,
                IdGiaoVien = x.IdGiaoVien,
                IdMonHoc = x.IdMonHoc,
               
                TietHoc = x.TietHoc,
                TrangThai = x.TrangThai
            }).ToList();
        }

        public async Task<string> ThemLopHoc(LopHoc lopHoc)
        {
            var newLH = await _context.lopHocs.FirstOrDefaultAsync(x => x.Id == lopHoc.Id);
            if(newLH != null)
            {
                return "Đã tồn tại lớp học";
            }

            if(string.IsNullOrEmpty(lopHoc.Id))
            {
                lopHoc.Id = Guid.NewGuid().ToString();
     
                _context.Add(lopHoc);
        
            } else
            {
                _context.Update(lopHoc);
            }
            //var listHocVien = _context.hocViens.Where(x => x.Id == lopHoc.lopHocVien.IdHocVien).ToList();
            //_context.RemoveRange(listHocVien);
            //if(lopHoc.ListHocVien != null)
            //{
            //    foreach(var item in lopHoc.ListHocVien) 
            //    { 
            //        item.Id = Guid.NewGuid().ToString();
            //        item.maLopHoc = lopHoc.Id;
            //    }
            //    _context.AddRange(lopHoc.ListHocVien);
            //}
            var listLopHV = _context.lopHocViens.Where(x => x.IdLop == lopHoc.Id).ToList();
            _context.RemoveRange(listLopHV);
            if(lopHoc.ListLopHocVien != null)
            {
                foreach(var item in lopHoc.ListLopHocVien)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.IdLop = lopHoc.Id;
                    item.HocVien.Id = Guid.NewGuid().ToString();
                    item.HocVien.IdLopHoc = item.Id;
                }
                _context.AddRange(lopHoc.ListLopHocVien);
            }

            var listLichHoc = _context.lichHocs.Where(x => x.IdLopHoc == lopHoc.Id).ToList();
            _context.RemoveRange(listLichHoc);
            if (lopHoc.ListLichHoc != null)
            {
                foreach (var item in lopHoc.ListLichHoc)
                {
                    item.Id = Guid.NewGuid().ToString();
                    item.IdLopHoc = lopHoc.Id;
                }
                _context.AddRange(lopHoc.ListLichHoc);
            }


            _context.SaveChanges();
            return "Thêm lớp học thành công";

        }

        public async Task XoaLopHoc(string id)
        {
            var delLH = _context.lopHocs.SingleOrDefault(x => x.Id == id);
            var listLopHocVien = _context.lopHocViens.Where(x => x.IdLop == id).ToList();
            var listLichHoc = _context.lichHocs.Where(x => x.IdLopHoc == id).ToList();
            if(delLH != null)
            {
                _context.lopHocs.Remove(delLH);
                _context.RemoveRange(listLopHocVien);
                _context.RemoveRange(listLichHoc);
                await _context.SaveChangesAsync();
            };
        }
    }
}
