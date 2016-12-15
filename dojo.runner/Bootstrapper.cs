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
    public static class Bootstrapper
    {
        public static IContainer Container;
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Dojo>().As<IDojo>();

            builder.RegisterType<NinjaTurtle>().As<INinjaTurtle>();
            builder.RegisterType<Cheese>().As<IPizza>();
            builder.RegisterType<Sai>().As<ITurtleWeapon>();
            builder.RegisterType<Raphael>().As<ITurtlePersona>();

            builder.RegisterType<FootClan>().As<IFootClan>();
            builder.RegisterType<Fists>().As<IFootWeapon>();
            builder.RegisterType<BeBop>().As<IFootClanPersona>();

            Container = builder.Build();
        }
    }
}