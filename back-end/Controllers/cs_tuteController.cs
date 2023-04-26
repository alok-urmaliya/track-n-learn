using back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cs_tuteController : ControllerBase
    {
        private readonly AppContext _appContext;

        public cs_tuteController(AppContext appContext) 
        {
            _appContext = appContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<cs_tute>>> GetCSharp()
        {
            if (_appContext.cs_tute == null)
            {
                return NotFound();
            }

            var csTutorial = _appContext.cs_tute.ToList();
            return csTutorial;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<cs_tute>> GetCSharp(Guid id)
        {
            if (_appContext.cs_tute == null)
            {
                return NotFound();
            }
            var tutorialBody = await _appContext.cs_tute.FindAsync(id);

            if (tutorialBody == null)
            {
                return NotFound();
            }

            return tutorialBody;
        }
    }
}
