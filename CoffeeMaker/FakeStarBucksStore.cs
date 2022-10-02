using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class FakeStarbucksStore : IMakeCoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        string IMakeCoffee.CoffeeMaking(int suggarPerSpone, int CoffeePack)
        {
            return "Your Order is Received.";
        }
    }
}