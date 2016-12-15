using System;

namespace dojo.lib.Personas.TurtlePersonas
{
    public class Leonardo : BaseTurtlePersona, ITurtlePersona
    {
        public override void Say()
        {
            Console.WriteLine(this.GetType().Name + ": We have had our first battle, Master Splinter! They were many, but we kicked...but we fought well.");
        }
    }
}