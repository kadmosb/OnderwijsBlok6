using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnderwijsBlok6
{
    public class Program
    {
        public static void ShiftRight(int[] lijst)
        {
            int aantalElementen = lijst.Length;
            int tmp = lijst[aantalElementen - 1];

            for (int i = aantalElementen - 1; i > 0; i--)
            {
                lijst[i] = lijst[i - 1];
            }

            lijst[0] = tmp;
        }

        public static void Swap(int[] lijst)
        {
            int aantalElementen = lijst.Length;
            int tmp = lijst[aantalElementen - 1];
            lijst[aantalElementen - 1] = lijst[0];
            lijst[0] = tmp;
        }

        public static void Largest(int[] lijst)
        {
            int aantalElementen = lijst.Length;

            for (int i = 1; i < (aantalElementen - 1); i++)
            {
                if (lijst[i - 1] > lijst[i + 1])
                {
                    lijst[i] = lijst[i - 1];
                }
                else
                {
                    lijst[i] = lijst[i + 1];
                }
            }
        }

        public static void OpdrachtP6_2()
        {
            // Gelukt. Nog een keer. Nog een keer.
            int[] lijst = new int[5];

            for (int i = 0; i < lijst.Length; i++)
            {
                lijst[i] = i;
            }

            /* Ook dit is gelukt */
            Swap(lijst);
            Console.WriteLine(String.Join(",", lijst));
            ShiftRight(lijst);
            Console.WriteLine(String.Join(", ", lijst));
            Largest(lijst);
            Console.WriteLine(String.Join(", ", lijst));
        }

        public static void OpdrachtP6_26()
        {
            List<int> lijst1 = new List<int>() { 1, 4, 9, 16 };
            List<int> lijst2 = new List<int>() { 9, 7, 4, 9, 11 };

            lijst2.ForEach(element => lijst1.Add(element));
            lijst1.ForEach(element => Console.WriteLine(element));
        }

        public static void OpdrachtP8_6()
        {
            Car myHybrid = new Car(50);
            myHybrid.drive(100);
            myHybrid.addGas(10);
            myHybrid.drive(100);
            Console.WriteLine("Fuel Level: " + myHybrid.GetFuelLevel());
        }

        public static void OpdrachtP9_8()
        {
            List<Persoon> lijst = new List<Persoon>();

            lijst.Add(new Student("Piet", 2001, "HBO-ICT"));
            lijst.Add(new Student("Pietje", 1998, "INF"));
            lijst.Add(new Instructor("Karel J.", 1968, 1088.99));

            lijst.ForEach(element =>
            {
                // if (element.YearOfBirth > 1990)
                {
                    Console.WriteLine(element.ToString());
                }
            });
        }

        public static void OpdrachtP9_14()
        {
            int teller = 0;
            double somOppervlaktes = 0;

            List<SodaCan> lijst = new List<SodaCan>();
            lijst.Add(new SodaCan(1, 2));
            lijst.Add(new SodaCan(2, 2));
            lijst.Add(new SodaCan(3, 3));

            lijst.ForEach(element => {
                somOppervlaktes += element.GetSurfaceArea();
                Console.WriteLine(element.GetSurfaceArea());
                teller++;
            });

            Console.WriteLine(somOppervlaktes / teller);
        }

        public static void OpdrachtR9_14()
        {
            Sandwich sub = new Sandwich();
            Rectangle cerealBox = new Rectangle(5, 10, 20, 30);
            Edible e = null;

            e = sub;
            //sub = e;
            sub = (Sandwich)e;
            // sub = cerealBox;
            // e = cerealBox;
             e = (Edible)cerealBox;
            // e = (Rectangle)cerealBox;
            // e = (Rectangle)null;
        }

        public static void Main(string[] args)
        {
            // OpdrachtP6_2();
            // OpdrachtP6_26();
            // OpdrachtP8_6();
            // OpdrachtP9_8();
            // OpdrachtP9_14();
            // OpdrachtR9_14();
            Console.ReadLine();
        }
    }
}
