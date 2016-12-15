﻿using System;
using dojo.lib.Personas.TurtlePersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Pizzas
{
    public class Pepperoni : IPizza
    {
        public void Eat(ITurtlePersona turtle)
        {
            Console.WriteLine(turtle + " eats a slice of Pepperoni pizza!");
        }
    }
}