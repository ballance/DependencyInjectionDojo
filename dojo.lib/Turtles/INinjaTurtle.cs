using Castle.DynamicProxy.Contributors;
using dojo.lib.FootClan;

namespace dojo.lib.Turtles
{
    public interface INinjaTurtle
    {
        void Attack(IFootClan target);
        void EatPizza();
        void Speak();
        void Defend();
    }
}