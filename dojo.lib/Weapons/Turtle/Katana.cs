using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.TurtlePersonas;

namespace dojo.lib.Weapons.Turtle
{
    public class Katana : BaseTurtleWeapon, ITurtleWeapon
    {
        private readonly ITurtlePersona _turtle;

        public Katana(ITurtlePersona turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " chops " + target + "with his Katana!");
            Console.WriteLine();
        }
    }

}