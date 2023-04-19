using Microsoft.Extensions.Caching.Memory;
using SonicHealthVendingMachineDataAccess.Model;
using SonicHealthVendingMachineService.Infrastructure;

namespace SonicHealthVendingMachineService.Services
{
    public class CanDrinkService : ICanDrinkService
    {
        private readonly ICacheProvider _cacheProvider;

        public CanDrinkService(ICacheProvider cacheProvider)
        {
            _cacheProvider = cacheProvider;
        }

        public List<DrinkDetail> GetCanDrinks()
        {
            return GetCachedResponse(CacheKeys.Drinks, () => SonicHealthVendingMachineBusinessLogic.DrinkLogic.GetDrinks());
        }

        private List<DrinkDetail> GetCachedResponse(string cacheKey, Func<List<DrinkDetail>> func)
        {
            var drinks = _cacheProvider.GetFromCache<List<DrinkDetail>>(cacheKey);
            if (drinks != null) return drinks;

            // Key not in cache, so get data.
            drinks = func();

            // Set cache options.
            var cacheEntryOptions = new MemoryCacheEntryOptions()
                // Keep in cache for this time, reset time if accessed.
                .SetSlidingExpiration(TimeSpan.FromHours(1));

            _cacheProvider.SetCache(cacheKey, drinks, cacheEntryOptions);

            return drinks;
        }

        public Task SaveCanDrinks(List<DrinkDetail> drinks)
        {
            _cacheProvider.SetCache(CacheKeys.Drinks, drinks);
            return Task.CompletedTask;
        }

        public Task RestockDrinks()
        {
            _cacheProvider.ClearCache(CacheKeys.Drinks);
            return Task.CompletedTask;
        }
    }
}
