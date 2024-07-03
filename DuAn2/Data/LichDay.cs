using System.ComponentModel.DataAnnotations.Schema;

namespace DuAn2.Data
{
    public class LichDay
    {
        public string Id { get; set; }
        public DayOfWeek? thu { get; set; }
        public DateTime? gioBatDau { get; set; }
        public DateTime? gioKetThuc { get; set; }
        public string GiaoVienId { get; set; }
    }

    public class TimeSlot
    {
        public string Id { get; set; }
        public DayOfWeek NgayTrongTuan { get; set; }
        public DateTime ThoiGian { get; set; }
        public string Confirm { get; set; }
    }
    public class KhungGio
    {
        public string Id { get; set; }
        public DateTime value { get; set; }
        
        public List<TimeSlot> TimeSlots { get; set; } = new List<TimeSlot>();
    }
}

