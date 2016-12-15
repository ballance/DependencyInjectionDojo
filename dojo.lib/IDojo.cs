using dojo.lib.FootClan;
using dojo.lib.Turtles;

namespace dojo.lib
{
    public interface IDojo
    {
        INinjaTurtle GetTurtle();
        IFootClan GetFootClan();
    }
}