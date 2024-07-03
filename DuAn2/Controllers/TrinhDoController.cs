using DuAn2.Data;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace QuanLyDuAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrinhDoController : ControllerBase
    {
        private readonly ITrinhDoRepository _trinhDoRepo;

        public TrinhDoController(ITrinhDoRepository repo) {
            _trinhDoRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> getAllTrinhDo()
        {
            return Ok(await _trinhDoRepo.getAllTrinhDo());
        }
        [HttpPost]
        public async Task<IActionResult> themTrinhDo(TrinhDo model)
        {
            var newtd = _trinhDoRepo.themTrinhDo(model);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> suaTrinhDo(string id, TrinhDo model)
        {
            await _trinhDoRepo.suaTrinhDo(id, model);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaTrinhDo(string id)
        {
            await _trinhDoRepo.xoaTrinhDo(id);
            return Ok();
        }
    }
}
