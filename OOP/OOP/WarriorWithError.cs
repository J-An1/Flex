
namespace OOP
{

using OOP.Armor.Mail;
using Weapon.Sharp;
    public class WarriorWithError
    {

        private int health; //fields
        private int takeHit; //fields
        private int level; //fields
        private string name; //fields
        private int abilitypoints;
        private string faction;
        private Axe weapon;
        private ChainLink bodyArmor;

        public int Health { get; set; } //property
        public int TakeHit { get; set; } //property
        public string Name { get; set; } //property

        public int Level { get; set; }
        public string Faction { get; set; }

        public Axe Weapon { get; set; }

        public ChainLink BodyArmor { get; set; }


        //public void Caio(string name)
        //{

        //   Console.WriteLine($"{Name} greets {name}");

        //}

        //public void Attack (Warrior emeny)
        //{

        //    emeny.Health -= TakeHit;
        //    Console.WriteLine($"{emeny} is being attacked by {Name} and {emeny} has {emeny.Health} remaining");

        //}

        public WarriorWithError (int takeHit, int health, string name)
        {

            Health = health; //property name is now being housed by argument passed upon creation
            TakeHit = takeHit;
            Name = name;

        }

    }
}
