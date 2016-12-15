using dojo.lib.FootClan;
using dojo.lib.Turtles;

namespace dojo.lib
{
    public class Dojo : IDojo
    {
        private readonly INinjaTurtle _ninjaTurtle;
        private readonly IFootClan _footClan;

        public Dojo(INinjaTurtle ninjaTurtle, IFootClan footClan)
        {
            _ninjaTurtle = ninjaTurtle;
            _footClan = footClan;
        }

        public INinjaTurtle GetTurtle()
        {
            return _ninjaTurtle;
        }

        public IFootClan GetFootClan()
        {
            return _footClan;
        }
    }
}
