using DuAn2.Data;

namespace DuAn2.Interface
{
    public interface ITKB
    {
        public dynamic findTKB(DateTime startDate, DateTime endDate);
        //public dynamic addTKB(TKB tkb);
        public dynamic LichTKB(DateTime startDate, DateTime endDate);
        public dynamic dltTKB(string id);
    }
}
