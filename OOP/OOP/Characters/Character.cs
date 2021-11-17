
namespace OOP.Characters
{

    using OOP.Enumerator;
    using OOP.Characters.Interface;
    using OOP.Armor;
    using OOP.Weapon;
    public abstract class Character : IAttack, IDefend
    {
        private const int DEF_LEVEL = 1;
        private const int DEF_HEALTH = 100;
        private const int DEF_ABILITY_POINTS = 1;

        private int health; //fields
        private int takeHit; //fields
        private int level; //fields
        private string name; //fields
        private int abilitypoints;
        private Faction faction;

        private Weapon weapon;
        private Armor bodyArmor;
        public Weapon Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        } //property
        public Armor BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        } //property

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value >= 0)
                {
                    health = value;
                }
                else
                {
                    System.Console.WriteLine("Health cannot be less than 0, Health is set to default");
                    health = DEF_HEALTH;
                }
            }
        } //property
        public int TakeHit
        {
            get
            {
                return takeHit;
            }
            set
            {
                takeHit = value;
            }
        } //property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 1 && value.Length <= 10)
                {
                    name = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException(string.Empty, "Asset name must be between 2 and 10 charaters");
                }
            }
        } //property
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 0)
                {
                    level = value;
                }
                else
                {
                    System.Console.WriteLine("Level cannot be less than 0, Level is set to default");
                    level = DEF_LEVEL;
                }
            }
        } //property
        public int AbilityPoints
        {
            get
            {
                return abilitypoints;
            }
            set
            {
                if (value >= 0)
                {
                    abilitypoints = value;
                }
                else
                {
                    System.Console.WriteLine("Ability cannot be less than 0, Ability point is set to default");
                    abilitypoints = DEF_ABILITY_POINTS;
                }
            }
        } //property
        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
            }
        } //property

        public abstract void Attack();

        public abstract void SpecialAttack();

        public abstract void Defend();

    }
}
