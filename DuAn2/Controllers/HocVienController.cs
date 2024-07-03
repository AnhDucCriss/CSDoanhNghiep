using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocVienController : ControllerBase
    {
        private readonly IHocVien _repoHocVien;

        public HocVienController(IHocVien repo) 
        { 
            _repoHocVien = repo;
        }

        [HttpGet]
        public IActionResult getAllHocVien(string ma, string ten, int page = 1)
        {
            try
            {
                var result = _repoHocVien.getAllHocVien(ma, ten, page);
                return Ok(result);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost] 
        public async Task<IActionResult> themHocVien(HocVien hv)
        {
            try
            {
                await _repoHocVien.themHocVien(hv);
                return Ok(hv);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaHocVien(string id)
        {
            try
            {
                await _repoHocVien.xoaHocVien(id);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
