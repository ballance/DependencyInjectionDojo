using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.FootClanPersonas;
using dojo.lib.Turtles;

namespace dojo.lib.Weapons.Foot
{
    public class Fists : BaseFootWeapon, IFootWeapon
    {
        private readonly string _footName;

        public Fists(IFootClanPersona footPersona)
        {
            _footName = footPersona.ToString();
        }

        public void Hit(INinjaTurtle target)
        {
            Console.WriteLine(_footName + " puhches " + target + " with his fists!");
            Console.WriteLine();
        }
    }
}