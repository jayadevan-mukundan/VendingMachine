using SonicHealthVendingMachineDataAccess.Model;

namespace SonicHealthVendingMachineBusinessLogic
{
    public static class DrinkLogic
    {
        public static List<DrinkDetail> GetDrinks()
        {
            var datasource = new SonicHealthVendingMachineDataAccess.DrinkData();
            return datasource.GetDrinks();
        }
    }
}