using SonicHealthVendingMachineDataAccess.Model;

namespace SonicHealthVendingMachineDataAccess
{
    public class DrinkData
    {
        public List <DrinkDetail> GetDrinks()
        {
            List<DrinkDetail> drinkDetails = new List<DrinkDetail>();

            drinkDetails.Add( new DrinkDetail { Number =1, Name = "Diet Coke", Price = 4.50M, ImageUrl= "diet-coke.jpg", Remaining= 10});
            drinkDetails.Add(new DrinkDetail { Number = 2, Name = "Fanta Grape", Price = 4.50M, ImageUrl = "fanta-grape.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 3, Name = "Mountain Dew", Price = 4.50M, ImageUrl = "mountaindew.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 4, Name = "Fanta GrapeFruit", Price = 4.50M, ImageUrl = "fanta-grapefruit.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 5, Name = "Coke Orange", Price = 4.50M, ImageUrl = "orangevanilla-coke.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 6, Name = "Schweppes", Price = 4.50M, ImageUrl = "schweppes.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 7, Name = "Sprite", Price = 4.50M, ImageUrl = "sprite.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 8, Name = "Coke Vanilla", Price = 4.50M, ImageUrl = "vanila-coke.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 9, Name = "Coke Zero Sugar", Price = 4.50M, ImageUrl = "zerosugar-coke.jpg", Remaining = 10 });
            drinkDetails.Add(new DrinkDetail { Number = 10, Name = "Coke Cherry", Price = 4.50M, ImageUrl = "cherry-coke.jpg", Remaining = 10 });

            return drinkDetails;
        }
    }
}