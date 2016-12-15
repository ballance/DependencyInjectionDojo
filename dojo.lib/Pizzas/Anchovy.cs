using System;
using dojo.lib.Personas.TurtlePersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Pizzas
{
    public class Anchovy : IPizza
    {
        public void Eat(ITurtlePersona turtle)
        {
            Console.WriteLine("Anchovies?!?  Turtles HATE anvchovies!1!");
        }
    }
}