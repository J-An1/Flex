
namespace OOP.Characters.Spellcaster
{

using OOP.Weapon.Blunt;
using OOP.Armor.Cloth;
using OOP.Enumerator;

    class Mage : Character
    {
        //private Staff weapon;
        //private ClothRobe bodyArmor;
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
        //public ClothRobe BodyArmor{ 
        //    get
        //    {
        //        return bodyArmor;
        //    }
        //    set
        //    {
        //        bodyArmor = value;
        //    } 
        //} //property
    
        public Mage (string name, int health, int level, Faction faction)
        {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 4;
            Weapon = new Staff();
            BodyArmor = new ClothRobe();
	    }

        public Mage()
        {

        }

        public void arcaneWrath()
        {
            throw new System.NotImplementedException();
        }

        public void fireWall()
        {
            throw new System.NotImplementedException();
        }

        public void meditation()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            this.fireWall();
        }

        public override void SpecialAttack()
        {
            this.arcaneWrath();
        }

        public override void Defend()
        {
            this.meditation();
        }
    }
}
