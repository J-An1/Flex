using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rng = new Random();


            int[] temp = new int [40];
            int[] lowTemp = new int[temp.Length];
            int[] midTemp = new int[temp.Length];
            int[] highTemp = new int[temp.Length];
            int[] xlTemp = new int[temp.Length];

            int lowTempIndex = 0;
            int midTempIndex = 0;
            int highTempIndex = 0;
            int xlTempIndex = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = rng.Next(0, 40);
            
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] >= 0 && temp [i] <= 10)
                {
                    lowTemp[lowTempIndex] = temp[i];
                    lowTempIndex++;
                }

                else if (temp[i] >= 11 && temp[i] <=20)
                {
                    midTemp[midTempIndex] = temp[i];
                    midTempIndex++;
                }

                else if (temp[i] >= 21 && temp[i] <= 30)
                {
                    highTemp[highTempIndex] = temp[i];
                    highTempIndex++;
                }

                else
                {
                    xlTemp[xlTempIndex] = temp[i];
                    xlTempIndex++;
                }
            }
        }


    }

}
