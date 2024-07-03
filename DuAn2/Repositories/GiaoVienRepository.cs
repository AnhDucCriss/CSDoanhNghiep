using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace DuAn2.Repositories
{
    public class GiaoVienRepository : IGiaoVien
    {
        private readonly WebContext _context;
        public static int PAGE_SIZE { get; set; } = 3;

        public GiaoVienRepository(WebContext context) { 
            _context = context;
        }

        public List<GiaoVien> getAllGiaoVien(string ma, string search, int page = 1)
        {
            var allGiaoVien = _context.giaoViens.AsQueryable();
            if(!string.IsNullOrEmpty(ma) && !string.IsNullOrEmpty(search))
            {
                allGiaoVien = _context.giaoViens.Where(x => x.maGiaoVien.Contains(ma) || x.tenGiaoVien.Contains(search));
            }
            
            //Phan trang
            var result = Pagination<GiaoVien>.Create(allGiaoVien, page, PAGE_SIZE);

            return result.Select(x => new GiaoVien {  
                Id = x.Id,
                maGiaoVien = x.maGiaoVien,
                tenGiaoVien = x.tenGiaoVien,
                gioiTinh = x.gioiTinh,
                ngaySinh = x.ngaySinh,
                cccd = x.cccd,
                IdTrinhDo = x.IdTrinhDo,
                soDienThoai = x.soDienThoai,
                email = x.email,
                diaChi = x.diaChi,
                soTaiKhoan = x.soTaiKhoan,
                nganHang = x.nganHang,
                maThue = x.maThue,
                trangThai = x.trangThai,
                listLichDay = x.listLichDay,
                listTienCong = x.listTienCong,
            }).ToList();

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
                _context.AddRange(model.listTienCong);
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
                _context.AddRange(model.listLichDay);
            }


            _context.SaveChanges();
            return "Thêm giáo viên thành công";
        }

        public async Task xoaGiaVien(string id)
        {
            var delGV = _context.giaoViens!.SingleOrDefault(x => x.Id == id);
            var listDelTC = _context.mucTienCongs.Where(x => x.GiaoVienId == id).ToList();
            var listDelLD = _context.lichDays.Where(x => x.GiaoVienId == id).ToList();
            if (delGV != null)
            {
                _context.giaoViens!.Remove(delGV);
                _context.RemoveRange(listDelLD); 
                _context.RemoveRange(listDelTC);
                await _context.SaveChangesAsync();

            };
        }
    }
}
