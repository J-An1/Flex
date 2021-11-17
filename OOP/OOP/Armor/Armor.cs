
namespace OOP.Armor
{

    using System;
    public abstract class Armor
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }

                else
                {
                    Console.WriteLine("Armor must be greater than 1, Armor point set to default");
                    armorPoints = 1;
                }
            }
        }

    }
}
