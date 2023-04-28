using back_end.Models;
using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class cpp_tuteController : ControllerBase
    {
        private readonly AppContext _appContext;

        public cpp_tuteController(AppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<cpp_tute>>> GetCpp()
        {
            if (_appContext.cpp_tute == null)
            {
                return NotFound();
            }

            var cppTutorial = _appContext.cpp_tute.OrderBy(e => e.topic_code).ToList();
            return cppTutorial;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<cpp_tute>> GetCpp(Guid id)
        {
            if (_appContext.cpp_tute == null)
            {
                return NotFound();
            }
            var tutorialBody = await _appContext.cpp_tute.FindAsync(id);

            if (tutorialBody == null)
            {
                return NotFound();
            }

            return tutorialBody;
        }
    }
}
