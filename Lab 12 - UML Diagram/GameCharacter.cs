using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___UML_Diagram
{
   abstract class GameCharacter
    {
        //fields and properties
        public  string Name { get; set; }

        public  int Strength { get; set; }

        public  int Intelligence { get; set; }

        //constructors
        public GameCharacter()
        {

        }

        //use this method in the main method.
        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {Name}");
            Console.WriteLine($"{Name}'s strength: {Strength}");
            Console.WriteLine($"{Name}'s Intelligence: {Intelligence}");
        }
    }
}
