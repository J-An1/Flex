
namespace OOP.Characters.Melee
{

using OOP.Weapon.Sharp;
using OOP.Armor.Leather;
using OOP.Enumerator;

    class Assasin : Character
    {      
        //private Sword weapon;
        //private LeatherVest bodyArmor;
        //public Sword Weapon{ 
        //    get
        //    {
        //        return weapon;
        //    }
        //    set
        //    {
        //        weapon = value;
        //    } 
        //} //property
        //public LeatherVest BodyArmor{ 
        //    get
        //    {
        //        return bodyArmor;
        //    }
        //    set
        //    {
        //        bodyArmor = value;
        //    } 
        //} //property

        public Assasin (string name, int health, int level, Faction faction)
	    {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 6;
            BodyArmor = new LeatherVest();
            Weapon = new Sword();
	    }

        public Assasin()
        {
 
        }
        
        public void raze()
        {
           throw new System.NotImplementedException();
        }

        public void bleed()
        {
            throw new System.NotImplementedException();
        }

        public void survival()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            this.raze();
        }

        public override void Defend()
        {
            this.survival();
        }

        public override void SpecialAttack()
        {
            this.bleed();
        }

    }
}
