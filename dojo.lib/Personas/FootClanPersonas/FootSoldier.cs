using System;

namespace dojo.lib.Personas.FootClanPersonas
{
    public class FootSoldier : BaseFootClanPersona, IFootClanPersona
    {
        public void Say()
        {
            Console.WriteLine(this.GetType().Name + ": We have a loyalty to the Shredder!");
        }
    }
}