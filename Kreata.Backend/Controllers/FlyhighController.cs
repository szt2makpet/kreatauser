using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FlyhighController : ControllerBase
{
    private IFlyhighRepo _flyhighRepo;
    public FlyhighController(IFlyhighRepo flyhighRepo)
    {
        _flyhighRepo = flyhighRepo;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBy(Guid id)
    {
        Flyhigh? entity = new();
        if (_flyhighRepo is not null)
        {
            entity = await _flyhighRepo.GetBy(id);
            if (entity != null)
                return Ok(entity);
        }
        return BadRequest("Az adatok elérhetetlenek!");
    }
    [HttpGet]
    public async Task<IActionResult> SelectAllRecordToListAsync()
    {
        List<Flyhigh>? users = new();
        if (_flyhighRepo != null)
        {
            users = await _flyhighRepo.GetAll();
            return Ok(users);
        }
        return BadRequest("Az adatok elérhetetlenek!");
    }
}
