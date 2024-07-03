using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DuAn2.Repositories
{
    public class TKBReposittory : ITKB
    {
        private readonly WebContext _context;

        public TKBReposittory(WebContext context)
        {
            _context = context;
        }
        public dynamic findTKB(DateTime startDate, DateTime endDate)
        {
            List<TKB> ListTKB = new List<TKB>();
            var ListTkbDaTao = _context.TKBs.Where(x => x.NgayHoc >= startDate && x.NgayHoc <= endDate).ToList();
            List<LichHoc> ListLichHoc = _context.lichHocs.ToList();
            var DSLichHocDaTaoIds = ListTkbDaTao.Select(x => x.IdLichHoc).Distinct().ToList();
            DateTime currentDate = startDate;
            while (currentDate <= endDate)
            {
                foreach(var items in ListLichHoc)
                {
                    if(items.Thu == currentDate.DayOfWeek )
                    {
                        if(!DSLichHocDaTaoIds.Contains(items.Id)) { 
                        TKB tkb = new TKB();
                        tkb.Id = Guid.NewGuid().ToString();
                        tkb.Thu = items.Thu;
                        tkb.NgayHoc = currentDate;
                        tkb.GioBatDau = items.GioBatDau;
                        tkb.GioKetThuc = items.GioKetThuc;
                        tkb.IdLopHoc = items.IdLopHoc;
                        tkb.IdLichHoc = items.Id;
                        ListTKB.Add(tkb);

                        DSLichHocDaTaoIds.Add(items.Id);
                        }

                    }
                    
                }
                currentDate = currentDate.AddDays(1);
            }
            _context.TKBs.AddRange(ListTKB);
            _context.SaveChanges();
            return ListTKB;
        }

       
        public dynamic LichTKB(DateTime startDate, DateTime endDate)
        {

            List<TKB> ListTKB = _context.TKBs.Where(x => x.NgayHoc <= endDate && x.NgayHoc >=startDate).ToList();
            List<ThoiDiem> danhSachThoiDiem = new List<ThoiDiem>();

            DateTime thoiDiemBD = new DateTime(startDate.Year, startDate.Month, startDate.Day, 6, 0, 0);
            DateTime thoiDiemKT = new DateTime(startDate.Year, startDate.Month, startDate.Day, 20, 0, 0);
            //LopHoc loph = _context.lopHocs.FirstOrDefault(x => x.Id == IdLopHoc);
            //HocVien hvien = _context.hocViens.FirstOrDefault(x => x.IdLopHoc == IdLopHoc);
            //GiaoVien gv = _context.giaoViens.FirstOrDefault(x => x.Id == loph.GiaoVienId);
            //MonHoc monHoc = _context.monHocs.FirstOrDefault(x => x.Id == loph.MonHocId);
            
            var DSIdLopHoc = ListTKB.Select(x => x.IdLopHoc).Distinct().ToList();
            List<LopHoc> ListLopHoc = _context.lopHocs
            .Where(x => DSIdLopHoc.Contains(x.Id))
            .ToList();

            List<HocVien> ListHocVien = _context.hocViens
            .Where(x => DSIdLopHoc.Contains(x.IdLopHoc))
            .ToList();
            var ListIDGV = ListLopHoc.Select(x => x.IdGiaoVien).Distinct().ToList();
            List<GiaoVien> ListGiaoVien = _context.giaoViens
            .Where(x => ListIDGV.Contains(x.Id))
            .ToList();
            var ListIdMH = ListLopHoc.Select(x => x.IdMonHoc).Distinct().ToList();  
            List<MonHoc> ListMonHoc = _context.monHocs
            .Where(x => ListIdMH.Contains(x.Id))
            .ToList();

            while (thoiDiemBD <= thoiDiemKT)
            {
                ThoiDiem thoiDiem = new ThoiDiem();
                thoiDiem.Id = Guid.NewGuid().ToString();
                thoiDiem.value = thoiDiemBD;
                DateTime startDateTMP = startDate;
                DateTime ThoiGianTmp = thoiDiemBD;
                while (startDateTMP <= endDate)
                {
                    List<LichTKB> ListLichTkb = new List<LichTKB>();
                    foreach(var item in ListTKB)
                    { 
                        
                        if(item.Thu == startDateTMP.DayOfWeek && item.GioBatDau <= ThoiGianTmp && item.GioKetThuc >= ThoiGianTmp)
                        {
                            LopHoc loph = ListLopHoc.FirstOrDefault(x => x.Id == item.IdLopHoc);
                            HocVien hvien = ListHocVien.FirstOrDefault(x => x.IdLopHoc == item.IdLopHoc);
                            GiaoVien gv = ListGiaoVien.FirstOrDefault(x => x.Id == loph.IdGiaoVien);
                            MonHoc monHoc = ListMonHoc.FirstOrDefault(x => x.Id == loph.IdMonHoc);

                            LichTKB LichTKB = new LichTKB(); 
                            LichTKB.Id = Guid.NewGuid().ToString();
                            LichTKB.ThoiGian = ThoiGianTmp;
                            LichTKB.Thu = startDateTMP.DayOfWeek;


                            if (loph != null && hvien != null && gv != null && monHoc != null)
                            {
                                LichTKB.Confirm = "Lớp: " + loph.MaLop + " HV: " + hvien.tenHocVien + " GV: " + gv.tenGiaoVien + " Môn: " + monHoc.tenMonHoc;
                            }


                            ListLichTkb.Add(LichTKB);
                        }

                    }
                    thoiDiem.ListLichTKB.AddRange(ListLichTkb);
                    startDateTMP = startDateTMP.AddDays(1);
                    ThoiGianTmp = ThoiGianTmp.AddDays(1);
                }

                danhSachThoiDiem.Add(thoiDiem);

                thoiDiemBD = thoiDiemBD.AddMinutes(15);
            }
            
            return danhSachThoiDiem;
        }



        public dynamic dltTKB(string id)
        {
            var result = new TKB();
            { result.Id = id; }

            _context.TKBs.Remove(result);
            _context.SaveChanges();
            return "xóa thành công";
        }
    }
}
