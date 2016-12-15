using System;

namespace dojo.lib.Pizzas
{
    public class Cheese : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("Ate a slice of cheese pizza!");
        }
    }

    public class Anchovy : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("Anchovies?!?  Turtles HATE anvchovies!1!");
        }
    }
}