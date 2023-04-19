using SonicHealthVendingMachineDataAccess.Model;

namespace SonicHealthVendingMachineService.Services
{
    public interface ICanDrinkService
    {
        List<DrinkDetail> GetCanDrinks();

        Task SaveCanDrinks(List<DrinkDetail> drinks);

        Task RestockDrinks();
    }
}
