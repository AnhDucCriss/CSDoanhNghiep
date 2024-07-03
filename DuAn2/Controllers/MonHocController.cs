using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonHocController : ControllerBase
    {
        private readonly IMonHoc _repoMonHoc;

        public MonHocController(IMonHoc repo)
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
