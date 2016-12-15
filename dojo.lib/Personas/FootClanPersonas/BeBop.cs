using System;

namespace dojo.lib.Personas.FootClanPersonas
{
    public class BeBop : BaseFootClanPersona, IFootClanPersona
    {
        public void Say()
        {
            Console.WriteLine(this.GetType().Name + ": Snort... Grunt...");
        }
    }
}