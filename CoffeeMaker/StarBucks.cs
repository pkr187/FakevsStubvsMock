using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class Starbucks : IMakeCoffee
    {
        public bool CheckIngridentAvalability()
        {
            return true;
        }
        string IMakeCoffee.CoffeeMaking(int suggarPerSpone, int CoffeePack)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Stub class of class starbucks.
    /// </summary>
    public class StubStarbucks : IMakeCoffee
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
