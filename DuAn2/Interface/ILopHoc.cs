using DuAn2.Data;

namespace DuAn2.Interface
{
    public interface ILopHoc
    {
        public List<LopHoc> GetAllLopHoc(string ma, int page = 1);
        public Task<string> ThemLopHoc(LopHoc lopHoc);
        public Task XoaLopHoc(string id);
    }
}
