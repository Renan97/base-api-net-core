using Microsoft.AspNetCore.Mvc;

namespace base_api_net_core.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    [HttpGet("procuradorias")]
    public async Task<IActionResult> GetProcuradoriasAsync()
    {
        var obj = new{
            nome = "proc 1",
            isActive = true
        };
        var obj2 = new{
            nome = "proc 2",
            isActive = false
        };
        Object[] result = {obj,obj2};
        return Ok(result);
    }
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
