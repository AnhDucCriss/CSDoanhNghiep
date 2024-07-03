using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDuAn.Data;
using QuanLyDuAn.Repositories;

namespace QuanLyDuAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoVienController : ControllerBase
    {
        private readonly IGiaoVienRepository _repoGiaoVien;

        public GiaoVienController(IGiaoVienRepository repo) 
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
            } catch
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
            } catch
            {
                return BadRequest();
            }
        }
    }
}
