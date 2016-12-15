using System;
using dojo.lib.Personas.TurtlePersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Pizzas
{
    public class Cheese : IPizza
    {
        public void Eat(ITurtlePersona turtle)
        {
            Console.WriteLine(turtle + " eats a slice of cheese pizza!");
        }
    }
}