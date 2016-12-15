using System;
using dojo.lib.FootClan;
using dojo.lib.Traits;

namespace dojo.lib.Weapons
{
    public class Katana : IWeapon
    {
        private readonly ITurtleTraits _turtle;

        public Katana(ITurtleTraits turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " chops " + target + "with his Katana!");
        }
    }

}