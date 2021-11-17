using OOP.Characters;
using OOP.Characters.Melee;
using System;

namespace OOP
{
    
       
    class Program
    {
        static void Main()
        {


            Character Flannigan = new Warrior();
            Character Zod = new Assasin();

            Zod.Attack();


            //Warrior goro = new Warrior("Zlatan", 100, 2, Enumerator.Faction.Spartan);



            //WarriorWithError thano = new WarriorWithError(10, 10, "worm");

        }
    }


}
