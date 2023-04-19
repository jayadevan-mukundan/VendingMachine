using SonicHealthVendingMachineDataAccess.Model;
using SonicHealthVendingMachineService.Infrastructure;

namespace SonicHealthVendingMachineService.Services
{
    public static class CacheKeys
    {
        public static string PaymentDetail => "_PaymentDetail";
        public static string Drinks => "_Drinks";
    }

    public class CacheService : ICacheService
    {
        private readonly ICacheProvider _cacheProvider;

        public CacheService(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;
        }

        public IEnumerable<DrinkDetail> GetCachedItems()
        {
            return _cacheProvider.GetFromCache<IEnumerable<DrinkDetail>>(CacheKeys.Drinks);
        }

        public void ClearCache()
        {
            _cacheProvider.ClearCache(CacheKeys.Drinks);
        }
    }
}
