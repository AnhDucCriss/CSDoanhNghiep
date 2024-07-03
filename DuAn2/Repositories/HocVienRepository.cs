using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Models;
using Microsoft.EntityFrameworkCore;

namespace DuAn2.Repositories
{
    public class HocVienRepository : IHocVien
    {
        private readonly WebContext _context;
        public static int PAGE_SIZE { get; set; } = 3;
        public HocVienRepository(WebContext context)
        {
            _context = context;
        }
        public List<HocVien> getAllHocVien(string ma, string ten, int page = 1)
        {
            var allHocVien = _context.hocViens.AsQueryable();
            if(!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(ten)) 
            {
                allHocVien = _context.hocViens.Where(x => x.maHocVien.Contains(ma) || x.tenHocVien.Contains(ten));
            }
            var result = Pagination<HocVien>.Create(allHocVien, page, PAGE_SIZE);

            return result.Select(x => new HocVien
            {
               Id = x.Id,
               maHocVien = x.maHocVien,
               tenHocVien = x.tenHocVien,
               gioiTinh = x.gioiTinh,
               ngaySinh = x.ngaySinh,
               soDT = x.soDT,
               email = x.email,
               diaChi = x.diaChi,
               trangThai = x.trangThai,
               tenCha = x.tenCha,
               soDTCha = x.soDTCha,
               ghiChuCha = x.ghiChuCha,
               emailCha = x.emailCha,
               tenMe = x.tenMe,
               soDTMe = x.soDTMe,
               emailMe = x.emailMe,
               ghiChuMe = x.ghiChuMe,
            }).ToList();
        }

        public async Task<string> themHocVien(HocVien hv)
        {
            HocVien hocVien = await _context.hocViens.FirstOrDefaultAsync(x => x.Id == hv.Id && x.Id != hv.Id);
            if (hocVien != null)
                return "Đã tồn tại học viên";
            if(string.IsNullOrEmpty(hv.Id))
            {
                hv.Id = Guid.NewGuid().ToString();
                _context.hocViens.Add(hv);
            }
            else
            {
                _context.hocViens.Update(hv);
            }
            _context.SaveChanges();
            return "Thêm học viên thành công";
        }

        public async Task xoaHocVien(string id)
        {
            var delHV = _context.hocViens.FirstOrDefault(x => x.Id == id);
            if(delHV != null)
            {
                _context.hocViens!.Remove(delHV);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
