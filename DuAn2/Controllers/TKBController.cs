using DuAn2.Data;
using DuAn2.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuAn2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TKBController : ControllerBase
    {
        private readonly ITKB _repo;

        public TKBController(ITKB repo) 
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> Get(DateTime sd, DateTime ed)
        {
            return Ok(_repo.findTKB(sd, ed));
        }
        //[HttpPost]
        //public async Task<IActionResult> AddTKB(TKB tkb)
        //{
        //    return Ok(_repo.addTKB(tkb));
        //}
        [HttpGet("{Get}")]
        public IActionResult GetLich(DateTime sd, DateTime ed)
        {
            return Ok(_repo.LichTKB(sd, ed));
        }
        [HttpDelete]
        public async Task<IActionResult> DelTKB(string id)
        {
            return Ok(_repo.dltTKB(id));
        }
    }

}
