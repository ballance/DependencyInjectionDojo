using System;
using dojo.lib.FootClan;
using dojo.lib.Traits;

namespace dojo.lib.Weapons
{
    public class BowStaff : IWeapon
    {
        private readonly ITurtleTraits _turtle;

        public BowStaff(ITurtleTraits turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " swings Bow staff at " + target + "!");
        }
    }
}