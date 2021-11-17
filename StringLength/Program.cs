using System;
using System.Threading;

namespace consoleThings
{
    class Program
    {
        static void Main()
        {
           
            Console.Title = "Nyx";
            //Console.CursorVisible = false;

            //Console.SetWindowSize(28, 15);
            //Console.SetBufferSize(28, 15);

            //string Prot = "Protein Intake for week 1";
            //float monday = 45.70594f;
            //float tuesday = 39.24967f;
            //float wed = 50.32678f;
            //float Thur = 90.23461f;
            //float fri = 12.94728f;
            //float sat = 56.30027f;
            //float sun = 34.12954f;

            //float total = monday + tuesday + wed + Thur + fri + sat + sun;

            //string sepa = new string('-', Prot.Length);

            //ConsoleColor oshe = ConsoleColor.DarkMagenta;

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("|" + Prot + "|");
            //Console.BackgroundColor = oshe;
            //Console.WriteLine("|" + sepa+"|");
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine("|" + $"{ monday, 25:N2}" + "|");
            //Console.WriteLine("|" + $"{tuesday,25:N2}"+"|");
            //Console.WriteLine("|" + $"{wed,25:N2}" +"|");
            //Console.WriteLine("|" + $"{Thur,25:N2}" +"|");
            //Console.WriteLine("|" + $"{fri,25:N2}" +"|");
            //Console.WriteLine("|" + $"{sat,25:N2}" +"|");
            //Console.WriteLine("|" + $"{sun,25:N2}" +"|");
            //Console.BackgroundColor = oshe;
            //Console.WriteLine("|" + sepa+"|");
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("|Total: " + $"{total,18:N2}" +"|");
            //Console.ResetColor();

            //Console.SetCursorPosition(5, 5);

            //do
            //{
            //    string Username = Console.ReadLine();

            //    bool usernameConditions = Username.Length > 8 || (int)Username[0] >= 65 && (int)Username[0] <= 90;

            //    Console.WriteLine(usernameConditions);
            //}

            //while (false);


            //Console.Read();

            //string TempUser = Console.ReadLine();
            //string TempPass = Console.ReadLine();

            //string User = string.Empty;
            //string Pass = string.Empty;

            //if (TempUser.Length < 6)
            //{

            //    User = TempUser;
            //}

            //Console.WriteLine(User);

            //Thread.Sleep(2000);

            Random rgn = new Random();

            //string we = "Job";
            //string them = "God";
            //int ourDamage = 0;
            //int theirDamage = 0;
            //int ourHealth = 100;
            //int theirHealth = 100;
            //bool gameOver = false;

            //while (!gameOver)
            //{

            //    ourDamage = rgn.Next(1, 7);
            //    theirDamage = rgn.Next(1, 8);
            //    ourHealth -= ourDamage;
            //    theirHealth -= theirDamage;

            //    Console.WriteLine($"{we} inflicted {theirDamage} upon {them} and their health is {theirHealth}");
            //    Console.WriteLine($"{them} inflicted {ourDamage} upon {we} and our health is {ourHealth}");


            //    if (ourHealth <= 0 || theirHealth <= 0)

            //        {
            //            gameOver = true;
            //        }

            //}


            //if (theirHealth <= 0)
            //    {
            //        Console.WriteLine($"The game is over, {we} won");
            //    }
            //else
            //    {
            //        Console.WriteLine($"The game is over, {them} won");
            //    }


            int[] intArray = new int[10];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rgn.Next(1, 10);

                if (intArray[i] % 2 == 0)
                {
                    Console.WriteLine($"The current index {i}, the current value {intArray[i]}");
                }
            
            }


        }
    }
}
