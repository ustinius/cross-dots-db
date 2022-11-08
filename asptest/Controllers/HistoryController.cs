using History.Core;
using Microsoft.AspNetCore.Mvc;

namespace asptest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : ControllerBase
    {
        public readonly Interface1 _history;
        public HistoryController(Interface1 history)
        {
           _history = history;
        }

        [HttpGet]
        public IActionResult GetHistories()
        {
            return Ok(_history.GetHistories());
        }
    }
}