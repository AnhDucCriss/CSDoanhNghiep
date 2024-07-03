using DuAn1.Data;
using DuAn1.Interface;
using DuAn1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DuAn1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoVienController : ControllerBase
    {
        private readonly IGiaoVien _repoGiaoVien;

        public GiaoVienController(IGiaoVien repo)
        {
            _repoGiaoVien = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllGiaoVien()
        {
            return Ok(await _repoGiaoVien.getAllGiaoVien());
        }
        [HttpPost]
        public async Task<IActionResult> themGiaoVien(GiaoVien model)
        {
            try
            {
                await _repoGiaoVien.themGiaoVien(model);
                return Ok(model);
            }
            catch
            {
                return BadRequest();
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> suaGiaoVien(string id, GiaoVien model)
        {
            try
            {
                await _repoGiaoVien.suaGiaoVien(id, model);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaGiaoVien(string id)
        {
            try
            {
                await _repoGiaoVien.xoaGiaVien(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
