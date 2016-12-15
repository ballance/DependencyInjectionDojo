using System;

namespace dojo.lib.Personas.FootClanPersonas
{
    public class Shredder : BaseFootClanPersona, IFootClanPersona
    {
        public void Say()
        {
            Console.WriteLine(this.GetType().Name + ": You fight well... in the old style. But you've caused me enough trouble. Now you face: the Shredder.");
        }
    }
}