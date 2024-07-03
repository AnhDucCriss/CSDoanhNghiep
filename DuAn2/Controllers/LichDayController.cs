using DuAn2.Interface;
using DuAn2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LichDayController : ControllerBase
    {
        private readonly ILichDay _repoLich;

        public LichDayController(ILichDay repo) 
        {
            _repoLich = repo;
        }
        [HttpGet]
        public IActionResult getLichRanh(string id)
        {
            try
            {
                var result = _repoLich.TimKhoangThoiGianRanh(id);
                return Ok(result);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }
}
