using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LopHocController : ControllerBase
    {
        private readonly ILopHoc _repo;

        public LopHocController(ILopHoc repo) 
        { 
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> getAllClass(string ma, int page = 1)
        {
            return Ok(_repo.GetAllLopHoc(ma, page));
        }

        [HttpPost]
        public async Task<IActionResult> themLopHoc(LopHoc lopHoc)
        {
            return Ok(await _repo.ThemLopHoc(lopHoc));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaLopHoc(string id)
        {
            try
            {
                await _repo.XoaLopHoc(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        
    }
}
