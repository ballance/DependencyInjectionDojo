using System;

namespace dojo.lib.FootClan
{
    public class BeBop : BaseFootClan, IFootClan
    {
        public void Attack()
        {
            Console.WriteLine("BeBop attacks!");
        }

        public void Defend()
        {
            Console.WriteLine("BeBop defends!");
        }
    }
}