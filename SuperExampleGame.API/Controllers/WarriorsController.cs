using Microsoft.AspNetCore.Mvc;
using SuperExampleGame.API.Models;
using SuperExampleGame.API.Models.Interfaces;
using SuperExampleGame.API.Models.Levels;
using SuperExampleGame.API.Models.Skills;
using SuperExampleGame.API.Services;

namespace SuperExampleGame.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WarriorController : ControllerBase
{
     private readonly ILogger<WarriorController> _logger;
    private readonly IWarriorService _warriorService;
    public WarriorController(IWarriorService warriorService){
            _warriorService = warriorService;
        
    }

    [HttpPost(Name = "BuyItemToEquip")]
    public async Task<ActionResult> BuyItemToEquip([FromBody]IItemEquipment itemToBuy, IUser user)
    {
        return Ok("ok");
    }
    [HttpGet(Name = "GetInitialWarrior")]
    public async Task<ActionResult<Warrior>> GetInitialWarrior()
    {
        var warrior = await _warriorService.GetInitialWarrior();
        if(warrior != null){
            return Ok(warrior);
        }
        return NotFound();
        
    }
}
