using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicHealthVendingMachineDataAccess.Model
{
    public class DrinkDetail
    {
        public DrinkDetail()
        {

        }
        public string? Name { get; set; }

        public decimal Price { get; set; }

        public int Remaining { get; set; }

        public int Number { get; set; }

        public string? ImageUrl { get; set; }
    }
}
