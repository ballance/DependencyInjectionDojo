using System;

namespace dojo.lib.Personas.TurtlePersonas
{
    public class Raphael : BaseTurtlePersona, ITurtlePersona
    {
        public override void Say()
        {
            Console.WriteLine(this.GetType().Name + ": Come back here! I'm not finished with you! DAMN!");
        }
    }
}