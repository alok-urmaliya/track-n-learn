using back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [Route("api/[Action]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly AppContext _appContext;

        public CommonController(AppContext appContext)
        {
            _appContext = appContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetTopics()
        {
            if (_appContext.javascript_tute == null)
            {
                return NotFound();
            }
            var topics = _appContext.javascript_tute.OrderBy(e => e.topic_code).Select(e => e.topic_name).ToList();
          
            return topics;
        } 
    }
}
