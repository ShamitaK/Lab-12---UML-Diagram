using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___UML_Diagram
{
    class Wizard : MagicUsingCharacter
    {
        //fields and properties
        public int SpellNumber { get; set; }

        //Constructors
        public Wizard()
        {

        }
        public Wizard(string _name, int _strength, int _intelligence, string _weaponType, string _magicalEnergy, int _spellNumber)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            SpellNumber = _spellNumber;
            MagicalEnergy = _magicalEnergy;
        }

        //in main method
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }

    }
}
