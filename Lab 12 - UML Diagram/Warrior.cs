using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___UML_Diagram
{
    class Warrior : GameCharacter
    {
        //fields and properties
        public string WeaponType { get; set; }

        //constructors
        public Warrior()
        {

        }
        
        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            WeaponType = _weaponType;
        }

        //in main method
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {WeaponType}");
        }

    }
}
