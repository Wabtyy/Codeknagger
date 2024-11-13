using System;
using System.Threading;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace Codeknagger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();

        }

        #region Menu
        static void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Level 1-9 auswählen.");
            Console.Write("Level: ");
            int lvl = int.Parse(Console.ReadLine());

            Console.Clear();
            if (lvl == 1) { lvl1(); }
            if (lvl == 2) { lvl2(); }
            if (lvl == 3) { lvl3(); }
            if (lvl == 4) { lvl4(); }
            if (lvl == 5) { lvl5(); }
            if (lvl == 6) { lvl6(); }
            if (lvl == 7) { lvl7(); }
            if (lvl == 8) { lvl8(); }
            if (lvl == 9) { lvl9(); }
        }
        #endregion

        #region level1
        static void lvl1()
        {

            Console.ForegroundColor = ConsoleColor.White;

            //zahl aussuchen
            int randoom = 2;

            //ausgabe
            Console.WriteLine("Geben Sie eine Zahl ein");
            int zahl = int.Parse(Console.ReadLine());
            Console.Clear();

            //gucken ob die ausgewählte zahl richtig ist
            if (randoom == zahl)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Die Zahl ist korrekt.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Die Zahl ist Falsch.");
            }

            Thread.Sleep(1000);
            Console.Clear();
            menu();


        }

        #endregion

        #region level2
        static void lvl2()
        {




            int randoom = 2;
            int zahl = 0;

            Console.ForegroundColor = ConsoleColor.White;
            //ausgabe
            Console.WriteLine("Geben Sie eine Zahl ein");
            zahl = int.Parse(Console.ReadLine());
            Console.Clear();


            if (zahl > 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Die Zahl darf nicht größer als 5 sein.");

            }
            if (zahl > randoom)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");

            }
            else if (zahl < randoom)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");

            }

            //gucken ob die ausgewählte zahl richtig ist
            if (randoom == zahl)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Die Zahl ist korrekt.");
            }

            Thread.Sleep(1000);
            Console.Clear();
            menu();
        }
    

             
            
            
        
        #endregion

        #region level3
        static void lvl3()
        {
            int randoom = 2;
            int zahl = 0;

            while (randoom != zahl)
            {
                Console.ForegroundColor = ConsoleColor.White;

                //zahl aussuchen
                

                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein");
                 zahl = int.Parse(Console.ReadLine());
               
           
                Console.Clear();
                if (zahl > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als 5 sein.");
                   
                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");
                   
                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");
                   
                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Die Zahl ist korrekt.");
                  
                }


                Thread.Sleep(1000);
                Console.Clear();

            }
        }
        #endregion

        #region level4
        static void lvl4()
            {
            
            int zahl = 0;
            int versuche = 0;
            int randoom = 3;

            while (randoom != zahl)
            {
                versuche++;


                Console.ForegroundColor = ConsoleColor.White;

                //zufällige zahl aussuchen


                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();

                if (zahl > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als 5 sein.");

                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");

                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");

                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Die Zahl ist korrekt.");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(1000);
                    Console.Clear();
                    menu();
                }


                Thread.Sleep(1000);
                Console.Clear();

            }
        }
        #endregion

        #region level5
        static void lvl5()
        {
            int randoom = 0;
            int zahl = 0;
            int versuche = 0;
            Random rnd = new Random();
            randoom = rnd.Next(0, 5);

            while (randoom != zahl)
            {
                versuche++;


                Console.ForegroundColor = ConsoleColor.White;

                //zufällige zahl aussuchen

            
                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein");
               zahl = int.Parse(Console.ReadLine());
                Console.Clear();

                if (zahl > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als 5 sein.");
                  
                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");
                   
                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");
                  
                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Die Zahl ist korrekt.");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(1000);
                    Console.Clear();
                    menu();
                }


                Thread.Sleep(1000);
                Console.Clear();

            }
        }
        #endregion

        #region level6

        static void lvl6()
        {
            int randoom = 0;
            int zahl = 0;
            int versuche = 0;
            Random rnd = new Random();
            randoom = rnd.Next() % 100 + 100;
           
            

            while (randoom != zahl)
            {
                versuche++;


                Console.ForegroundColor = ConsoleColor.White;

                //zufällige zahl aussuchen


                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein (100-200)");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();

                if (zahl > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als 5 sein.");

                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");

                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");

                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Die Zahl ist korrekt.");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(1000);
                    Console.Clear();
                    menu();
                }


                Thread.Sleep(1000);
                Console.Clear();

            
        }
     }
        #endregion

        #region level7
        static void lvl7()
        {
            int randoom = 0;
            int zahl = 0;
            int versuche = 0;
            Random rnd = new Random();

            Console.WriteLine("gebe einen zahlenreaum ein. z.b. \"3-5\"");
            string read = Console.ReadLine();
            string[] parameter = read.Split('-');
            randoom = rnd.Next(int.Parse(parameter[0]), int.Parse(parameter[1]));



            while (randoom != zahl)
            {
                versuche++;


                Console.ForegroundColor = ConsoleColor.White;

                //zufällige zahl aussuchen


                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein ("+parameter[0]+"-"+ parameter[1]+ ")");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();
                int mverlgiech = int.Parse(parameter[1]);
                if (zahl > mverlgiech)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als "+parameter[1]+" sein.");
                  
                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");

                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");

                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    double Wahrscheinlichkeit = 1.0 / (obergrenze - untergrenze);
					for (int i = 1; i < versuche; i++)
					{
						Wahrscheinlichkeit *= 2;
					}
					
					if(versuche!=1)
					{
					Wahrscheinlichkeit*=2;
					}
					
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Die Zahl ist korrekt.");
					Console.WriteLine($"Die Wahrscheinlichkeit, die Zahl in {versuche} Versuchen zu erraten, liegt bei: {(Wahrscheinlichkeit*100).ToString("F2")}%");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(2500);
                    Console.Clear();
                    menu();
                }
                Thread.Sleep(2500);




            }
            Thread.Sleep(1000);
            Console.Clear();
            menu();
        }
    
        #endregion

        #region level8
        static void lvl8()
        {
            int randoom = 0;
            int zahl = 0;
            int versuche = 0;
            Random rnd = new Random();

            Console.WriteLine("gebe einen zahlenreaum ein. z.b. \"3-5\"");
            string read = Console.ReadLine();
            string[] parameter = read.Split('-');
            randoom = rnd.Next(int.Parse(parameter[0]), int.Parse(parameter[1]));



            while (randoom != zahl)
            {
                versuche++;


                Console.ForegroundColor = ConsoleColor.White;

                //zufällige zahl aussuchen


                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein (" + parameter[0] + "-" + parameter[1] + ")");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();
                int mverlgiech = int.Parse(parameter[1]);
                if (zahl > mverlgiech)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als " + parameter[1] + " sein.");

                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");

                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");

                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                    double Wahrscheinlichkeit = 1.0 / (obergrenze - untergrenze);
					for (int i = 1; i < versuche; i++)
					{
						Wahrscheinlichkeit *= 2;
					}
					
					if(versuche!=1)
					{
					Wahrscheinlichkeit*=2;
					}
					
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Die Zahl ist korrekt.");
					Console.WriteLine($"Die Wahrscheinlichkeit, die Zahl in {versuche} Versuchen zu erraten, liegt bei: {(Wahrscheinlichkeit*100).ToString("F2")}%");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(2500);
                    Console.Clear();
                    menu();
                }
                Thread.Sleep(2500);

            }
            Thread.Sleep(1000);
            Console.Clear();
            menu();
        }
    
        #endregion

        #region level9
        static void lvl9()
        {
            int randoom = 0;
            int zahl = 0;
            int versuche = 0;
            int counter = 0;
            Random rnd = new Random();

            Console.WriteLine("gebe einen zahlenreaum ein. z.b. \"3-5\"");
            string read = Console.ReadLine();
            string[] parameter = read.Split('-');
            randoom = rnd.Next(int.Parse(parameter[0]), int.Parse(parameter[1]));

            int obergrenze = int.Parse(parameter[1]); //40
            obergrenze += 1;
            int untergrenze = int.Parse(parameter[0]); //10
          

           int zahlenraum = obergrenze - untergrenze; //30

                     //40          //30
            while (2 <= zahlenraum)
            {
                counter++;
                zahlenraum = zahlenraum / 2;
            }
            while (randoom != zahl)
            {
                versuche++;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                //ausgabe
                Console.WriteLine("Geben Sie eine Zahl ein (" + parameter[0] + "-" + parameter[1] + ")");
                zahl = int.Parse(Console.ReadLine());
                Console.Clear();
                int mverlgiech = int.Parse(parameter[1]);
                if (zahl > mverlgiech)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Zahl darf nicht größer als " + parameter[1] + " sein.");
                }
                if (zahl > randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre zahl ist größer, wie die zufallszahl.");
                }
                else if (zahl < randoom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ihre zahl ist kleiner, wie die zufallszahl.");
                }
                //gucken ob die ausgewählte zahl richtig ist
                if (randoom == zahl)
                {
                  if(counter> versuche)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Die zahl wurde in der optimalen anzahl an versuchen erraten.");
                    }
                  else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Die zahl wurde nicht in der optimalen anzahl an veruschen erraten.");
                    }
					
					double Wahrscheinlichkeit = 1.0 / (obergrenze - untergrenze);
					for (int i = 1; i < versuche; i++)
					{
						Wahrscheinlichkeit *= 2;
					}
					
					if(versuche!=1)
					{
					Wahrscheinlichkeit*=2;
					}
					
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine($"Die Wahrscheinlichkeit, die Zahl in {versuche} Versuchen zu erraten, liegt bei: {(Wahrscheinlichkeit*100).ToString("F2")}%");
                    Console.WriteLine("Die Zahl ist korrekt.");
                    Console.WriteLine("Sie haben " + versuche + " gebraucht");

                    Thread.Sleep(5000);
                    Console.Clear();
                    menu();
                }
                Thread.Sleep(2500);
            }
            Thread.Sleep(1000);
            Console.Clear();
            menu();
        }
        #endregion
    }
}
