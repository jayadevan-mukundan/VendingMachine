using Microsoft.Extensions.Caching.Memory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SonicHealthVendingMachineService.Infrastructure;

namespace SonicHealthVendingMachineTests
{

    [TestClass]
    public class ServiceTests
    {
        private static TestContext? _testContext = null;
        SonicHealthVendingMachineService.Services.CanDrinkService service = new SonicHealthVendingMachineService.Services.CanDrinkService(new CacheProvider(new MemoryCache(new MemoryCacheOptions())));

        [ClassInitialize]
        public static void TestInitialize(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestMethod]
        public void GetDrinkLists()
        {
            var drinks = service.GetCanDrinks();
            Assert.AreEqual(drinks.Count() ,10);
        }

        [TestMethod]
        public void SaveDrinkList()
        {
            var drinks = service.GetCanDrinks();
            var firstDrink = drinks.Where(d => d.Number == 1).First();
            firstDrink.Remaining = 5;
            service.SaveCanDrinks(drinks);

            var newdrinklist = service.GetCanDrinks();

            Assert.AreEqual(drinks.Where(d => d.Number == 1).First().Remaining, 5);
        }
    }
}