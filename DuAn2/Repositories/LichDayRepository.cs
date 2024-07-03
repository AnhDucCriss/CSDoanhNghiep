using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.AspNetCore.Http.Features;
using System;

namespace DuAn2.Repositories
{
    public class LichDayRepository : ILichDay
    {
        private readonly WebContext _context;

        public LichDayRepository(WebContext context)
        {
            _context = context;
        }

        public List<KhungGio> TimKhoangThoiGianRanh(string id)
        {
            List<LichDay> listLD = _context.lichDays
                                        .Where(x => x.GiaoVienId == id)
                                        .ToList();

            List<KhungGio> danhSachKhungGio = new List<KhungGio>();
            DateTime timeNow = DateTime.Today;
            var startDate = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 6, 0, 0);
            var EndDate = new DateTime(timeNow.Year, timeNow.Month, timeNow.Day, 20, 0, 0);
            
            while(startDate <= EndDate)
            {
                KhungGio khungGio = new KhungGio();

                khungGio.Id = Guid.NewGuid().ToString();
                khungGio.value = startDate;
                DayOfWeek dayOfWeek = DayOfWeek.Sunday;
                for (int day = 0; day < 7; day++)
                {
                    TimeSlot slotTime = new TimeSlot
                    {
                        Id = Guid.NewGuid().ToString(),
                        NgayTrongTuan = dayOfWeek
                    };
                    bool isAvailable = !listLD.Any(lich =>
                        lich.thu == dayOfWeek &&
                        lich.gioBatDau <= khungGio.value &&
                        khungGio.value <= lich.gioKetThuc);
                    if (slotTime.NgayTrongTuan == dayOfWeek && isAvailable == true)
                    {
                        slotTime.Confirm = "Rảnh";
                    }
                    else
                    {
                        slotTime.Confirm = "Bận";
                    }
                    khungGio.TimeSlots.Add(slotTime);
                    dayOfWeek++;
                }

                danhSachKhungGio.Add(khungGio);

                startDate = startDate.AddMinutes(15);
            }

            return danhSachKhungGio;
        }
    }
}
