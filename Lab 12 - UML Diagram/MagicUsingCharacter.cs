using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___UML_Diagram
{
    class MagicUsingCharacter : GameCharacter
    {
        //fields and properties
        public string MagicalEnergy { get; set; }

        //constructors
        public MagicUsingCharacter()
        {

        }

        public MagicUsingCharacter(string _name, int _strength, int _intelligence, string _weaponType, string _magicalEnergy)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
        }

        //in main method
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magic Enery: {MagicalEnergy}");
        }

    }
}
