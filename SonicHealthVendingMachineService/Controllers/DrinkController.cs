using Microsoft.AspNetCore.Mvc;
using SonicHealthVendingMachineDataAccess.Model;
using SonicHealthVendingMachineService.Services;

namespace SonicHealthVendingMachineService.Controllers;

[ApiController]
[Route("[controller]")]
public class DrinkController : ControllerBase
{
    private readonly ILogger<DrinkController> _logger;
    private readonly ICanDrinkService _canDrinkService;
    private readonly ICacheService _cacheService;

    public DrinkController(ILogger<DrinkController> logger, ICanDrinkService canDrinkService, ICacheService cacheService)
    {
        _logger = logger;
        _canDrinkService = canDrinkService;
        _cacheService = cacheService;
    }

    [HttpGet()]
    [Route("DrinkList")]
    public IEnumerable<DrinkDetail> GetDrinks()
    {
        return _canDrinkService.GetCanDrinks();
    }

    [HttpPost()]
    [Route("DrinkList/Save")]
    public IEnumerable<DrinkDetail> SaveDrinks([FromBody] List<DrinkDetail> data)
    {
        _canDrinkService.SaveCanDrinks(data);
        return _canDrinkService.GetCanDrinks();
    }

    [HttpPost()]
    [Route("DrinkList/Restock")]
    public void RestockDrinks()
    {
        _canDrinkService.RestockDrinks();
    }
}
