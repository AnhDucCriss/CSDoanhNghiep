using DuAn2.Data;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QuanLyDuAn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongHocController : ControllerBase
    {
        private readonly IPhongHocRepository _phongHocRepo;

        public PhongHocController(IPhongHocRepository repo)
        {
            _phongHocRepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> getAllPhongHoc()
        {
            return Ok(await _phongHocRepo.getAllPhongHoc());
        }

        [HttpPost]
        public async Task<IActionResult> themPhongHoc(PhongHoc model)
        {
            var newPhongHoc = await _phongHocRepo.themPhongHoc(model);
            var phonghoc = await _phongHocRepo.getAllPhongHoc();
            return phonghoc == null ? NotFound() : Ok(phonghoc);
        }
        
        

        [HttpPut("{id}")]
        public async Task<IActionResult> SuaPhongHoc(string id, PhongHoc model)
        {
            await _phongHocRepo.suaPhongHoc(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> xoaPhongHoc(string id) 
        {
            await _phongHocRepo.xoaPhongHoc(id);
            return Ok();
        }

    }
}
