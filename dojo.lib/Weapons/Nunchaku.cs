using System;
using dojo.lib.FootClan;
using dojo.lib.Traits;

namespace dojo.lib.Weapons
{
    public class Nunchaku : IWeapon
    {
        private readonly ITurtleTraits _turtle;

        public Nunchaku(ITurtleTraits turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " spins Numchaku at " + target + "!");
        }
    }
}