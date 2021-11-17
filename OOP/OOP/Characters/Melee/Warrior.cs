
namespace OOP.Characters.Melee
{

using OOP.Armor.Mail;
using OOP.Weapon.Sharp;
using OOP.Enumerator;

    class Warrior : Character
    {
        //private Axe weapon;
        //private ChainLink bodyArmor;
        //public Axe Weapon{ 
        //    get
        //    {
        //        return weapon;
        //    }
        //    set
        //    {
        //        weapon = value;
        //    } 
        //} //property

        //public ChainLink BodyArmor{ 
        //    get
        //    {
        //        return bodyArmor;
        //    }
        //    set
        //    {
        //        bodyArmor = value;
        //    } 
        //} //property


        public Warrior(string name, int health, int level, Faction faction)
        {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 2;
            Weapon = new Axe();
            BodyArmor = new ChainLink();        
        }

        public Warrior()
        {

        }

        public void strike()
        {
            throw new System.NotImplementedException();
        }

        public void execute()
        {
            throw new System.NotImplementedException();
        }

        public void skinHarden()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            this.strike();
        }

        public override void SpecialAttack()
        {
            this.execute();
        }

        public override void Defend()
        {
            this.skinHarden();
        }
    }
}
