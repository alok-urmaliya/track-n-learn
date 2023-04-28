using back_end.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class javascript_tuteController : ControllerBase
    {
        private readonly AppContext _appContext;

        public javascript_tuteController(AppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<javascript_tute>>> GetJavascript()
        {
            if (_appContext.javascript_tute== null)
            {
                return NotFound();
            }

            var javascriptTutorial = _appContext.javascript_tute.OrderBy(e => e.topic_code).ToList();
            return javascriptTutorial;
            //to get inactive employees also.
            //return await _context.Employee.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<javascript_tute>> GetJavascript(Guid id)
        {
            if (_appContext.javascript_tute == null)
            {
                return NotFound();
            }
            var tutorialBody = await _appContext.javascript_tute.FindAsync(id);

            if (tutorialBody == null)
            {
                return NotFound();
            }

            return tutorialBody;
        }
    }
}
