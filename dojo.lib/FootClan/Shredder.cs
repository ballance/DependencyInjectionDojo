using System;

namespace dojo.lib.FootClan
{
    public class Shredder : BaseFootClan, IFootClan
    {
        public void Attack()
        {
            Console.WriteLine("Shredder attacks!");
        }

        public void Defend()
        {
            Console.WriteLine("Shredder defends!");
        }
    }
}