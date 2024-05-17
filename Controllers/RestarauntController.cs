using YizhaAPI.Models;
using YizhaAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace YizhaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestarauntController : Controller
    {
        public RestarauntController()
        {
            
        }

        [HttpGet]
        public ActionResult<List<Restaraunt>> GetRestaraunts() => (new RestarauntService()).GetRestaraunts();

        [HttpGet("{id}")]
        public ActionResult<Restaraunt> GetRestarauntById(int id)
        {
            RestarauntService restarauntService = new RestarauntService();
            var restaraunt = restarauntService.GetById(id);

            if (restaraunt == null)
                NotFound();

            return Ok(restaraunt);
        }
    }
}
