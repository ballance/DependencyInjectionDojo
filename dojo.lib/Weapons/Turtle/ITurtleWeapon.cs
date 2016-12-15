using Castle.DynamicProxy.Contributors;
using dojo.lib.FootClan;

namespace dojo.lib.Weapons.Turtle
{
    public interface ITurtleWeapon
    {
        void Hit(IFootClan target);
    }
}