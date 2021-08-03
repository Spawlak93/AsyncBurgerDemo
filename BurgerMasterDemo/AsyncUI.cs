using BurgerMasterDemo.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMasterDemo
{
    public class AsyncUI
    {
        public void Run()
        {
            BurgerMaster burgerMaster = new BurgerMaster();            

            Patty patty = burgerMaster.CookPatty();
            Console.WriteLine("Patty Done");
            Fries fries = burgerMaster.FryFries();
            Console.WriteLine("Fries Done");
            Bun bun = burgerMaster.ToastBun();
            Console.WriteLine("Bun Toasted");
            Produce produce = burgerMaster.ChopProduce();
            Console.WriteLine("Produce Chopped");

            burgerMaster.AssembleBurger();
            Console.WriteLine("Enjoy Burger");

            Console.ReadKey();
        }
    }
}
