using DuAn2.Data;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System.Diagnostics.Eventing.Reader;



namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DungCuController : ControllerBase
    {
        private readonly IDungCuRepository _dungCuRepo;

        public DungCuController(IDungCuRepository repo) 
        {
            _dungCuRepo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> getAllDungCu()
        {
            return Ok(await _dungCuRepo.GetDungCus());
        }

        [HttpPost]
        public async Task<IActionResult> themDungCu(DungCu model)
        {
            var newDungCu = await _dungCuRepo.themDungCu(model);
            var dungcu = await _dungCuRepo.GetDungCus();
            return dungcu == null ? NotFound() : Ok(dungcu);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> suaDungCu(string id, DungCu model)
        {
            await _dungCuRepo.suaDungCu(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaDungCu(string id)
        {
            await _dungCuRepo.xoaDungCu(id);
            return Ok();
        }

    }
}
