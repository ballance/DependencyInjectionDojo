using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.TurtlePersonas;

namespace dojo.lib.Weapons.Turtle
{
    public class Sai : BaseTurtleWeapon, ITurtleWeapon
    {
        private readonly ITurtlePersona _turtle;

        public Sai(ITurtlePersona turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " thrusts Sai at " + target + "!");
            Console.WriteLine();
        }
    }
}