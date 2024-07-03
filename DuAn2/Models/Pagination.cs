namespace DuAn2.Models
{
    public class Pagination<T> : List<T>
    {
        public int pageIndex { get; set; }
        public int totalPage { get; set; }
        public Pagination(List<T> items, int count, int PageIndex, int pageSize)
        {
            pageIndex = PageIndex;
            totalPage = (int)Math.Ceiling((double)count / pageSize);
            AddRange(items);
        }

        public static Pagination<T> Create(IQueryable<T> source, int pageIndex, int pageSize) 
        {
            var count = source.Count();
            var items = source.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();
            return new Pagination<T>(items, count, pageIndex, pageSize);
        }
    }
}
