using System;

namespace Trabalhob2
{
    class Program
    {
        static void Main(String[] args)
        {
            Agricultural wheat = new Agricultural("Wheat", 100.00, 150);
            Agricultural sugarCane = new Agricultural("Sugar Cane", 50, 100);
            Agricultural coffe = new Agricultural("Coffe ", 20, 170);
            Agricultural soy = new Agricultural("Soy", 10, 210);

            Industrialized chips = new Industrialized("Chips", 15, 32);
            Industrialized cookie = new Industrialized("Cookie", 17, 190);
            Industrialized pizza = new Industrialized("Pizza", 43, 110);
            Industrialized cheese = new Industrialized("Cheese", 25, 60);


            List<Product> products = new List<Product>();
            products.Add(sugarCane);
            products.Add(coffe);
            products.Add(soy);
            products.Add(chips);
            products.Add(cookie);
            products.Add(pizza);
            products.Add(cheese);
        }
    }
}
