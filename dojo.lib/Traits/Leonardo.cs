using System;

namespace dojo.lib.Traits
{
    public class Leonardo : BaseTurtleTrait, ITurtleTraits
    {
        public override void Say()
        {
            Console.WriteLine("We have had our first battle, Master Splinter! They were many, but we kicked...but we fought well.");
        }
    }
}