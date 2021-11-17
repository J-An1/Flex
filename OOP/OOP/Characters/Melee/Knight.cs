
namespace OOP.Characters.Melee

{
using OOP.Weapon.Blunt;
using OOP.Armor.Mail;
    using OOP.Enumerator;

    class Knight : Character
    {       
        //private Hammer weapon;
        //private ChainLink bodyArmor;            
        //public Hammer Weapon { 
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
    
        public Knight (string name, int health, int level, Faction faction)
        {
            Name = name;
            Health = health;
            Level = level;
            Faction = faction;
            AbilityPoints = 4;
            Weapon = new Hammer();
            BodyArmor = new ChainLink();
        }

        public Knight()
        {
            
        }


        public void holyBlow()
        {
            throw new System.NotImplementedException();            
        }

        public void purifySoul()
        {
            throw new System.NotImplementedException();
        }

        public void righteousWings()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack()
        {
            this.holyBlow();
        }

        public override void Defend()
        {
            this.righteousWings();
        }

        public override void SpecialAttack()
        {
            this.purifySoul();
        }

    }
}
