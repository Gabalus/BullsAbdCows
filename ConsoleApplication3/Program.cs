using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Игра против Компьютера");
                Console.WriteLine("2. Игра против человека");
                Console.WriteLine("0. Выход");
                string rk = Console.ReadLine();
                while (true)
                {
                    try
                    {
                        switch (rk)
                        {
                            case "1":
                                string temp = GameRun.generateNumber();
                                Playgame playgame = new Playgame(new Game(temp));       

                                GameRun.playvscomp(playgame);
                                break;
                            case "2":
                                Playgame playgame2 = new Playgame(new Game(GameRun.manualNumberentry()));
                                GameRun.playvsplayer(playgame2);
                                break;
                            case "0":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Неверный выбор");
                                break;
                        }
                    }
                    catch (GenerateException)
                    {
                    }
                    catch (Exception ex)
                    {

                        if (GameRun.isfinished)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            break;
                        }
                        else
                            Console.WriteLine(ex.Message);
                    }
                }

        }
    }
        
    }
}


