namespace chorescore.Controllers;

[ApiController]
[Route("api/[controller]")]


public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> Get()
  {
    try
    {
      var chores = _choresService.GetChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Chore> GetChore(int id)
  {
    try
    {
      var chore = _choresService.GetChore(id);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPost]
  public ActionResult<Chore> Create([FromBody] Chore choreData)
  {
    try
    {
      var chore = _choresService.AddChore(choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpDelete]
  public ActionResult<Chore> RemoveChore(int id)
  {
    try
    {
      var chore = _choresService.RemoveChore(id);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
  [HttpPut]
  public ActionResult<Chore> EditChore(int id, [FromBody] Chore choreData)
  {
    try
    {
      var chore = _choresService.EditChore(id, choreData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}



