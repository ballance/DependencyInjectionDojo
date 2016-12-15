using System;
using dojo.lib.FootClan;
using dojo.lib.Personas.TurtlePersonas;
using dojo.lib.Pizzas;
using dojo.lib.Weapons.Turtle;

namespace dojo.lib.Turtles
{
    public class NinjaTurtle : INinjaTurtle
    {
        private readonly ITurtleWeapon _weapon;
        private readonly IPizza _pizza;
        private readonly ITurtlePersona _turtlePersona;
        private string _name;
        private readonly string _turtleNameOverride; // Only present for the non-DI example

        public NinjaTurtle(string turtleName)
        {
            _turtleNameOverride = turtleName;
            // This one is not useful and should not be called... (only here for the non-DI example)
        }

        public NinjaTurtle(ITurtleWeapon weapon, IPizza pizza, ITurtlePersona turtlePersona)
        {
            _weapon = weapon;
            _pizza = pizza;
            _turtlePersona = turtlePersona;
        }

        public void Attack(IFootClan target)
        {
            _weapon.Hit(target);
            target.Defend();
        }

        public void EatPizza()
        {
            _pizza.Eat(_turtlePersona);
        }

        public void Speak()
        {
            _turtlePersona.Say();
        }

        public void Defend()
        {
            Console.WriteLine(_turtlePersona + " defends with " + _weapon ?? "" + "!");
        }

        public override string ToString()
        {
           return _turtlePersona == null ? _turtleNameOverride : _turtlePersona.ToString();
        }
    }
}