using dojo.lib.FootClan;
using dojo.lib.Traits;

namespace dojo.lib.Turtles
{
    public interface INinjaTurtle
    {
        void Attack(IFootClan target);
        void EatPizza();
        void Speak();
    }
}