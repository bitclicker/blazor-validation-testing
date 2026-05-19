using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ValidationExample.Client.Models;

namespace ValidationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post(FormModel model)
        {
            return Ok();
        }
    }
}
