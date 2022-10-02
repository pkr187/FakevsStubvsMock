using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarbuckStore
    {
        private readonly IMakeCoffee service;
        public StarbuckStore(IMakeCoffee service)
        {
            this.service = service;
        }
        public string OrderCoffee(int suggarPerSpone, int CoffeeCount)
        {
            if (service.CheckIngridentAvalability())
            {
                return service.CoffeeMaking(suggarPerSpone, CoffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }
        }
    }
}

