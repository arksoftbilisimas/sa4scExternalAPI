using Microsoft.AspNetCore.Mvc;
using SA4SC.External.API.Dto;

namespace SA4SC.External.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModernController : ControllerBase
    {
        [HttpPost("Validate")]
        public async Task<ModernLoginResponseDto> Validate(ModernLoginRequestDto pLoginDto)
        {
            try
            {
                return await Task.FromResult(new ModernLoginResponseDto());
            }
            catch
            {
                return await Task.FromResult(new ModernLoginResponseDto());
            }
        }

        [HttpGet("TestApi")]
        public async Task<ActionResult> TestApi()
        {
            return await Task.FromResult(Ok(true));
        }
    }
}
