using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dojo.lib.Turtles;

namespace dojo.lib.Weapons.Foot
{
    public interface IFootWeapon
    {
        void Hit(INinjaTurtle target);
    }
}
