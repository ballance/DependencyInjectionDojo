using System;
using System.Reflection;
using dojo.lib.FootClan;
using dojo.lib.Traits;

namespace dojo.lib.Weapons
{
    public class Sai : IWeapon
    {
        private readonly ITurtleTraits _turtle;

        public Sai(ITurtleTraits turtle)
        {
            _turtle = turtle;
        }

        public void Hit(IFootClan target)
        {
            Console.WriteLine(_turtle + " thrusts Sai at " + target + "!");
        }
    }
}