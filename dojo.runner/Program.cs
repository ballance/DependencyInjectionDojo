using System;
using Autofac;
using dojo.lib;
using dojo.lib.FootClan;
using dojo.lib.Pizzas;
using dojo.lib.Traits;
using dojo.lib.Turtles;
using dojo.lib.Weapons;

namespace dojo.runner
{
    class Program
    {
        public static void Main()
        {
            ContstuctorInjectionDojo();
            //DependencyInjectionDojo();

            Console.ReadKey();
        }

        private static void ContstuctorInjectionDojo()
        {
            var turtle = new NinjaTurtle(new BowStaff(new Donatello()), new Cheese(), new Donatello());
            var foot = new Shredder();

            turtle.Speak();
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

            turtle.Attack(foot);
            Console.WriteLine();

            turtle.EatPizza();
            Console.WriteLine();
        }
    }
}
