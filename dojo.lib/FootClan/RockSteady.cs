using System;

namespace dojo.lib.FootClan
{
    public class RockSteady : BaseFootClan, IFootClan
    {
        public void Attack()
        {
            Console.WriteLine("RockSteady attacks!");
        }

        public void Defend()
        {
            Console.WriteLine("RockSteady defends!");
        }
    }
}