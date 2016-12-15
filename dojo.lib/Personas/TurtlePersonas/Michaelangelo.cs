using System;

namespace dojo.lib.Personas.TurtlePersonas
{
    public class Michaelangelo : BaseTurtlePersona, ITurtlePersona
    {
        public override void Say()
        {
            Console.WriteLine(this.GetType().Name +  ": Go! Move it, will ya? Aw, you're letting him blow right by ya! Can you believe this guy? Come on! Don't just...! Ninja-kick the damn rabbit! Do something!");
        }

     }
}