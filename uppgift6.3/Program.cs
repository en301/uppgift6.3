using System;

namespace uppgift_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 0;
            do
            {
                Console.WriteLine("1.Addera");
                Console.WriteLine("1.Största talet av två tal");
                Console.WriteLine("3.Avsluta programmet");
                val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        {
                            Console.WriteLine("Skriv ut tre tal du vill addera");
                            int tal1 = int.Parse(Console.ReadLine());
                            int tal2 = int.Parse(Console.ReadLine());
                            int tal3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Summan av talen blir " + MenyvalAddera(tal1, tal2, tal3));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Skriv in 2 tal");
                            int tal1 = int.Parse(Console.ReadLine());
                            int tal2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Största talet var " + MenyvalStörstatal(tal1, tal2));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Programmet avslutas...");
                            break;
                        }
                }
            } while (val != 3);
        }
        static int MenyvalAddera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static int MenyvalStörstatal(int tal1, int tal2)
        {
            if (tal1 >= tal2)
            {

                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}
