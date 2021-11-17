
namespace OOP.Weapon
{
    public abstract class Weapon
    {

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (damage >= 1)
                {
                    damage = value;
                }
                else
                {
                    System.Console.WriteLine("Damage cannot be less than 1, Damage is set to default");
                    damage = 1;
                }
            }
        }


    }
}
