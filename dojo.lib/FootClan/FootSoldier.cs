using System;

namespace dojo.lib.FootClan
{
    public class FootSoldier : BaseFootClan, IFootClan
    {
        public void Attack()
        {
            Console.WriteLine("Foot Soldier attacks!");
        }

        public void Defend()
        {
            Console.WriteLine("Foot Soldier defends!");
        }
    }
}