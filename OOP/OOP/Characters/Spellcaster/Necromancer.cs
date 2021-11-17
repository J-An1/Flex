
namespace OOP.Characters.Spellcaster
{

using OOP.Weapon.Sharp;
using OOP.Armor.Leather;
using OOP.Enumerator;

    class Necromancer : Character
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
    
        public Necromancer (string name, int health, int level, Faction faction)
        {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 4;
            Weapon = new Sword();
            BodyArmor = new LeatherVest();
	    }

        public Necromancer()
        {

        }

        public void shadowRage()
        {
            throw new System.NotImplementedException();
        }

        public void vampireTouch()
        {
            throw new System.NotImplementedException();
        }

        public void boneShield()
        {
            throw new System.NotImplementedException();
        }

        public override void Defend()
        {
            this.boneShield();
        }

        public override void Attack()
        {
            this.vampireTouch();
        }

        public override void SpecialAttack()
        {
            this.shadowRage();
        }

    }
}
