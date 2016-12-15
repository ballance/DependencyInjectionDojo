using System;

namespace dojo.lib.Personas.TurtlePersonas
{
    public abstract class BaseTurtlePersona : ITurtlePersona
    {
        public virtual void Say()
        {
            Console.Write("Turtle: COWABUNGA!!1!");
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}