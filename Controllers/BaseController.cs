using Microsoft.AspNetCore.Mvc;

namespace base_api_net_core.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        return Ok("get");
    }
    [HttpPost()]
    public async Task<IActionResult> PostAsync([FromBody] Base obj)
    {
        return Ok("post");
    }

    [HttpPatch("{id}")]
    public async Task<IActionResult> PatchAsync(int id, [FromBody] Base obj)
    {
        return Ok("patch");
    }
    [HttpPatch("updatename/{id}")]
    public async Task<IActionResult> UpdateNameAsync(int id, [FromBody] UpdateNameDto obj)
    {
        return Ok("update name");
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync()
    {
        return Ok("delete");
    }
}
