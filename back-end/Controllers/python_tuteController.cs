using back_end.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class python_tuteController : ControllerBase
    {
        private readonly AppContext _appContext;

        public python_tuteController(AppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<python_tute>>> GetPython()
        {
            if (_appContext.python_tute == null)
            {
                return NotFound();
            }

            var pythonTutorial = _appContext.python_tute.OrderBy(e => e.topic_code).ToList();
            return pythonTutorial;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<python_tute>> GetPython(Guid id)
        {
            if (_appContext.python_tute == null)
            {
                return NotFound();
            }
            var tutorialBody = await _appContext.python_tute.FindAsync(id);

            if (tutorialBody == null)
            {
                return NotFound();
            }

            return tutorialBody;
        }
    }
}
