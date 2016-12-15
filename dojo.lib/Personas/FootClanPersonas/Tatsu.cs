using System;

namespace dojo.lib.Personas.FootClanPersonas
{
    public class Tatsu : BaseFootClanPersona, IFootClanPersona
    {
        public void Say()
        {
            Console.WriteLine(this.GetType().Name + ": Ninja... vanish!");
        }
    }
}