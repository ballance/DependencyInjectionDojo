using System;

namespace dojo.lib.Pizzas
{
    public class Pepperoni : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("Ate a slice of cheese pizza!");
        }
    }
}