using System;
using System.Runtime.InteropServices;
using dojo.lib.Personas.FootClanPersonas;
using dojo.lib.Turtles;
using dojo.lib.Weapons.Foot;

namespace dojo.lib.FootClan
{
    public class FootClan : IFootClan
    {
        private readonly IFootClanPersona _footClanPersona;
        private readonly IFootWeapon _weapon;
        private string _footNameOverride;

        public FootClan(IFootClanPersona footClanPersona, IFootWeapon weapon)
        {
            _footClanPersona = footClanPersona;
            _weapon = weapon;
        }
        public FootClan(string footName)
        {
            _footNameOverride = footName;
            // This one is not useful and should not be called... (only here for the non-DI example)
        }

        public void Attack(INinjaTurtle turtle)
        {
            _weapon.Hit(turtle);
            turtle.Defend();
        }

        public void Defend()
        {
            Console.WriteLine(_footClanPersona + " defends with " + _weapon ?? "" + "!");
        }

        public void Speak()
        {
            _footClanPersona.Say();
        }

        public override string ToString()
        {
            return _footClanPersona == null ? _footNameOverride : _footClanPersona.ToString();
        }
    }
}