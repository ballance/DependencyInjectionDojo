using System;

namespace dojo.lib.Traits
{
    public class Raphael : BaseTurtleTrait, ITurtleTraits
    {
        public override void Say()
        {
            Console.WriteLine("Come back here! I'm not finished with you! DAMN!");
        }
    }
}