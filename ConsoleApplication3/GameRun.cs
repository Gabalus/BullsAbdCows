using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public static class GameRun
    {
        public static bool isfinished = false;
        public static int lenghtnumber;
        public static void playvscomp(Playgame playgame)
        {
           
            while (true)
            {
                Console.WriteLine($"Введите ответ длинной-{lenghtnumber}");
                string answer = Console.ReadLine();
                Console.WriteLine(playgame.nextStep(answer));
                playgame.nextStep(answer);

            }
        }

        public static string generateNumber()
        {
            Random rand = new Random();

            int r = rand.Next(int.MaxValue);

            return r.ToString();
        }



        public static void playvsplayer(Playgame playgame)
        {
            
            while (true)
            {
                Console.WriteLine("Введите ответ");
                string answer = Console.ReadLine();
                Console.WriteLine(playgame.nextStep(answer));
                playgame.nextStep(answer);
            }
        }

        public static string manualNumberentry()
        {
            Console.WriteLine("Загадайте число");
            string number = Console.ReadLine();
            Console.Clear();
            return number;
        }
    }
}
