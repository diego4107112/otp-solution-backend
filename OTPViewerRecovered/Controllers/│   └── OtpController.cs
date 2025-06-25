using Microsoft.AspNetCore.Mvc;
using OTPViewerRecovered.Data;
using OTPViewerRecovered.Models;

namespace OTPViewerRecovered.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly DwContext _context;

        public OtpController(DwContext context)
        {
            _context = context;
        }

        [HttpGet("view")]
        public IActionResult GetOtpCodes()
        {
            var val = _context.CodigosOtpV.ToList();
            return Ok(val);
        }
    }
}
