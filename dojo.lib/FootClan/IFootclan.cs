using dojo.lib.Turtles;

namespace dojo.lib.FootClan
{
    public interface IFootClan
    {
        void Attack(INinjaTurtle target);

        void Defend();

        void Speak();
    }
}