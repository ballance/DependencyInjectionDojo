using dojo.lib.FootClan;
using dojo.lib.Pizzas;
using dojo.lib.Traits;
using dojo.lib.Weapons;

namespace dojo.lib.Turtles
{
    public class NinjaTurtle : INinjaTurtle
    {
        private IWeapon _weapon;
        private IPizza _pizza;
        private ITurtleTraits _turtleTraits;
        private string _name;

        public NinjaTurtle(IWeapon weapon, IPizza pizza, ITurtleTraits turtleTraits)
        {
            _weapon = weapon;
            _pizza = pizza;
            _turtleTraits = turtleTraits;
        }

        public void Attack(IFootClan target)
        {
            _weapon.Hit(target);
            target.Defend();
        }

        public void EatPizza()
        {
            _pizza.Eat();
        }

        public void Speak()
        {
            _turtleTraits.Say();
        }
    }
}