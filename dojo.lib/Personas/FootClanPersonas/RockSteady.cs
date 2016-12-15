using System;

namespace dojo.lib.Personas.FootClanPersonas
{
    public class RockSteady : BaseFootClanPersona, IFootClanPersona
    {
        public void Say()
        {
            Console.WriteLine(this.GetType().Name + ": Grunt... Snort...");
        }
    }
}