using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.TurtlePersonas;

namespace dojo.lib.Weapons.Turtle
{
    public class Nunchaku : BaseTurtleWeapon, ITurtleWeapon
    {
        private readonly ITurtlePersona _turtle;

        public Nunchaku(ITurtlePersona turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " spins Numchaku at " + target + "!");
            Console.WriteLine();
        }
    }
}