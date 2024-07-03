using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDuAn.Data;
using QuanLyDuAn.Repositories;

namespace QuanLyDuAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly IMonHocRepository _repoMonHoc;

        public MonHocController(IMonHocRepository repo)
        {
            _repoMonHoc = repo;
        }

        [HttpGet]
        public async Task<IActionResult> getAllMonHoc()
        {
            return Ok(await _repoMonHoc.getAllMonHoc());
        }

        [HttpPost]
        public async Task<IActionResult> themMonHoc(MonHoc model)
        {
            var newmh = await _repoMonHoc.themMonHoc(model);
            return Ok(newmh);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> suaMonHoc(string id, MonHoc model)
        {
             await _repoMonHoc.suaMonHoc(id, model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaMonHoc(string id)
        {
            await _repoMonHoc.xoaMonHoc(id);
            return Ok();
 
        }
        
    }
}
