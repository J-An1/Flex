
namespace OOP.Characters.Spellcaster
{

using OOP.Weapon.Blunt;
using OOP.Armor.Leather;
using OOP.Enumerator;

    class Druid : Character
    {
        //private Staff weapon;
        //private LeatherVest bodyArmor;
        //public Staff Weapon{ 
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
    
        public Druid (string name, int health, int level, Faction faction)
        {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 6;
            Weapon = new Staff();
            BodyArmor = new LeatherVest();
	    }

        public Druid()
        {

        }
        
        public void moonFire()
        {
            throw new System.NotImplementedException();
        }

        public void starBurst()
        {
            throw new System.NotImplementedException();
        }

        public void oneWithNature()
        {
            throw new System.NotImplementedException();
        }

        public override void Defend()
        {
            this.oneWithNature();
        }

        public override void Attack()
        {
            this.moonFire();
        }

        public override void SpecialAttack()
        {
            this.starBurst();
        }

    }
}
