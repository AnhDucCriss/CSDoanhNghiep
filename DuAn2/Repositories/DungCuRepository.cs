using Microsoft.EntityFrameworkCore;
using DuAn2.Data;


namespace DuAn2.Repositories
{
    public class DungCuRepository : IDungCuRepository
    {
        private readonly WebContext _context;

        public DungCuRepository(WebContext context) 
        { 
            _context = context;
        }
        public async Task<List<DungCu>> GetDungCus()
        {
            var dcs = await _context.dungCus!.ToListAsync();
            return dcs;
        }
        public async Task<DungCu> GetDungCuById(string id)
        {
            var dc = await _context.dungCus!.FindAsync(id);
            return dc;
        }

        public async Task suaDungCu(string id, DungCu model)
        {
            if(id == model.Id)
            {
                _context.dungCus!.Update(model);
                await _context.SaveChangesAsync();

            }
        }

        public async Task<string> themDungCu(DungCu model)
        {
            _context.dungCus!.Add(model);
            await _context.SaveChangesAsync();

            return model.Id;
        }

        public async Task xoaDungCu(string id)
        {
            var delDungcu = _context.dungCus!.SingleOrDefault(dungcu => dungcu.Id == id);
            if(delDungcu != null)
            {
                _context.dungCus!.Remove(delDungcu);
                await _context.SaveChangesAsync();
            }
        }

       
    }
}
