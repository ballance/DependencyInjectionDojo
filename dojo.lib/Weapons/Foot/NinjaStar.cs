using System;
using dojo.lib.Personas.FootClanPersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Weapons.Foot
{
    public class NinjaStar : BaseFootWeapon, IFootWeapon
    {
        private readonly string _footName;

        public NinjaStar(IFootClanPersona footPersona)
        {
            _footName = footPersona.ToString();
        }

        public void Hit(INinjaTurtle target)
        {
            Console.WriteLine(_footName + " throws a " + this.GetType().Name + " at " + target + "!");
            Console.WriteLine();
        }
    }
}