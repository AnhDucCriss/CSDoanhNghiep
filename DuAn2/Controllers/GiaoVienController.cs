using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DuAn2.Controllers
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
        public IActionResult GetAllGiaoVien(string ma, string search, int page = 1)
        {
            try
            {
                var result = _repoGiaoVien.getAllGiaoVien(ma, search, page);
                return Ok(result);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);      
            }
            
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
