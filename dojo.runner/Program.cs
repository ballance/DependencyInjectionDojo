using System;
using Autofac;
using dojo.lib;
using dojo.lib.FootClan;
using dojo.lib.Personas.FootClanPersonas;
using dojo.lib.Personas.TurtlePersonas;
using dojo.lib.Pizzas;
using dojo.lib.Turtles;
using dojo.lib.Weapons.Foot;
using dojo.lib.Weapons.Turtle;

namespace dojo.runner
{
    class Program
    {
        public static void Main()
        {
            ConstuctorInjectionDojo();
            //DependencyInjectionDojo();

            Console.ReadKey();
        }

        private static void ConstuctorInjectionDojo()
        {
            var donatello = new Donatello();
            var turtle = new NinjaTurtle(new BowStaff(donatello), new Pepperoni(), donatello);
            var foot = new FootClan(new Shredder(), new Armorblades("Shredder"));

            turtle.Speak();
            Console.WriteLine();

            foot.Attack(turtle);
            Console.WriteLine();

            foot.Speak();
            Console.WriteLine();

            turtle.Attack(foot);
            Console.WriteLine();

            turtle.EatPizza();
            Console.WriteLine();
        }

        private static void DependencyInjectionDojo()
        {
            Bootstrapper.Configure();
            var container = Bootstrapper.Container;
            var dojo = container.Resolve<IDojo>();

            var turtle = dojo.GetTurtle();
            var foot = dojo.GetFootClan();

            turtle.Speak();
            Console.WriteLine();

            foot.Attack(turtle);
            Console.WriteLine();

            foot.Speak();
            Console.WriteLine();

            turtle.Attack(foot);
            Console.WriteLine();

            turtle.EatPizza();
            Console.WriteLine();
        }
    }
}
