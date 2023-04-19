using SonicHealthVendingMachineDataAccess.Model;

namespace SonicHealthVendingMachineService.Services
{
    public interface ICacheService
    {
            IEnumerable<DrinkDetail> GetCachedItems();
            void ClearCache();
    }
}
