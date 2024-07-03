using Microsoft.EntityFrameworkCore;
using DuAn2.Controllers;
using DuAn2.Data;

namespace DuAn2.Repositories
{
    public class PhongHocRepository : IPhongHocRepository
    {
        private readonly WebContext _context;

        public PhongHocRepository(WebContext context)
        {
            _context = context;
        }
        public async Task<List<PhongHoc>> getAllPhongHoc()
        {
            var books = await _context.phongHocs!.ToListAsync();
            return books;
        }

        public async Task<PhongHoc> getPhongHocById(string id)
        {
            var book = await _context.phongHocs!.FindAsync(id);
            return book;
        }

        public async Task suaPhongHoc(string id, PhongHoc model)
        {
            if(id == model.Id)
            {

                List<PhongHoc_DungCu> listphdc = _context.phongHoc_DungCus.Where(x => x.PhongHocId == id).ToList();
                foreach(var item in listphdc)
                {
                    foreach (var phgoc in model.listDungCu)
                    {
                        item.DungCuId = phgoc.DungCuId;
                       
                    }
                }
                _context.phongHocs!.Update(model);

                await _context.SaveChangesAsync();
            }
        }

        public async Task<string> themPhongHoc(PhongHoc model)
        {
            PhongHoc newph = new PhongHoc();
            newph.Id = model.Id;
            newph.tenPhongHoc = model.tenPhongHoc;
            newph.ghiChu = model.ghiChu;
            List<PhongHoc_DungCu> list_phdc = new List<PhongHoc_DungCu>();
            foreach (var item in model.listDungCu)
            {
                item.PhongHocId = model.Id;
                list_phdc.Add(item);
            }
            _context.phongHoc_DungCus.AddRange(list_phdc);
            _context.phongHocs!.Add(newph);
            

            await _context.SaveChangesAsync();

            return model.Id;
        }

        public async Task xoaPhongHoc(string id)
        {
            var delPhongHoc = _context.phongHocs!.SingleOrDefault(phonghoc => phonghoc.Id == id);

            if (delPhongHoc != null)
            {
                var dcph = _context.phongHoc_DungCus.Where(x=>x.PhongHocId == id).ToList();
                _context.phongHoc_DungCus!.RemoveRange(dcph);
                _context.phongHocs!.Remove(delPhongHoc);
                await _context.SaveChangesAsync();
            }
            
        }
    }
}
