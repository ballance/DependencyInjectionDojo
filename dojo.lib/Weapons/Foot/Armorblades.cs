using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.FootClanPersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Weapons.Foot
{
    public class Armorblades : BaseFootWeapon, IFootWeapon
    {
        private readonly string _footName;

        public Armorblades(IFootClanPersona foot)
        {
            _footName = foot.ToString();
        }

        public Armorblades(string footName)
        {
            _footName = footName;
        }

        public void Hit(INinjaTurtle target)
        {
            Console.WriteLine(_footName + " swipes at " + target + " with his Armor Blades!");
            Console.WriteLine();
        }
    }
}