using System;

namespace Lab_12___UML_Diagram
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] gameCharacters = new GameCharacter[]
            {
                //print two warriors and three wizards
                new Warrior("Mario", 50, 100, "fireballs"),
                new Warrior("Donkey Kong", 100, 20, "giant banana"),
                new Wizard("Jafar", 80, 90, "snake staff", "evil magic", 40),
                new Wizard("Potter", 100, 100, "wand", "spell types", 20),
                new Wizard("Tom", 80, 20, "stick", "telepathy", 10)
            };

            //went this route over a for loop because it is cleaner and no need 
            //manipuate info which a for loop would be the one to use.
            foreach(GameCharacter gameCharacter in gameCharacters)
            {
                gameCharacter.Play();
                Console.WriteLine();
            }
        }
    }
}
