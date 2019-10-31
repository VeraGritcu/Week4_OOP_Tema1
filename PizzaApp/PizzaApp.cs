using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class PizzaApp
    {
        static void Main(string[] args)
        {
            PizzaTopping top = new PizzaTopping();
            top.Name = "Cheese";
            PizzaTopping top2 = new PizzaTopping();
            top2.Name = "Meat";
            PizzaTopping top3 = new PizzaTopping();
            top3.Name = "Vegetable";

            PizzaBase base1 = new PizzaBase();
            PizzaBase base2 = new PizzaBase();
            PizzaBase base3 = new PizzaBase();

            Pizza pizza = new Pizza(base1, "Margerita");
            pizza.AddTopping(top2);
            pizza.AddTopping(top);

            Pizza pizza2 = new Pizza(base2, "Indiana");
            pizza2.AddTopping(top2);

            Pizza pizza3 = new Pizza(base3,"Arabella");
            pizza3.AddTopping(top3);
            pizza.Print();
            pizza2.Print();
            pizza3.Print();
           
        }
    }
}
