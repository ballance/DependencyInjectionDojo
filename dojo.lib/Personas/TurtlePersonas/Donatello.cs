using System;

namespace dojo.lib.Personas.TurtlePersonas
{
    public class Donatello : BaseTurtlePersona, ITurtlePersona
    {
        public override void Say()
        {
            Console.WriteLine(this.GetType().Name + ": Hey, guys, I'm not so sure this is, uh, structurally speaking, such a good time for your, uh, buddies to drop in...");
        }
    }
}