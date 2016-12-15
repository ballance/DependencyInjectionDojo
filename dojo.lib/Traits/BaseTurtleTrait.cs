using System;

namespace dojo.lib.Traits
{
    public abstract class BaseTurtleTrait : ITurtleTraits
    {
        public virtual void Say()
        {
            Console.Write("COWABUNGA!!1!");
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}