using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.TurtlePersonas;

namespace dojo.lib.Weapons.Turtle
{
    public class BowStaff : BaseTurtleWeapon, ITurtleWeapon
    {
        private readonly ITurtlePersona _turtle;

        public BowStaff(ITurtlePersona turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " swings Bow staff at " + target + "!");
            Console.WriteLine();
        }
    }
}