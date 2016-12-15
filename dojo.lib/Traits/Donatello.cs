using System;

namespace dojo.lib.Traits
{
    public class Donatello : BaseTurtleTrait, ITurtleTraits
    {
        public override void Say()
        {
            Console.WriteLine("Hey, guys, I'm not so sure this is, uh, structurally speaking, such a good time for your, uh, buddies to drop in...");
        }
    }
}