using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int c;
            
            string menu = "\nA :Adaugare cutie \nL :Afisare date despretoate cutiile \nFafisati cutiile de o anumite culoare \nC :Afisati prentru fiecare cutiile care au lungimea ,latimea si adancimea mai mica \nX :Exit";
            Console.WriteLine(menu);
            Cutie[] cutii = new Cutie[50];
            do
            {

                string op = Console.ReadLine();
                switch (op)
                {
                    case "a":
                        {
                            Console.WriteLine("Introduceti numarul de cutii pe care doriti sa le adaugati");
                            c = Convert.ToInt32(Console.ReadLine());
                            for (int j = i; j < c; j++)
                            {
                                double lun, lat, ad;
                                Console.WriteLine("Introduceti lungimea cubului nr " + j);
                                lun = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Introduceti latimea cubului nr " +j);
                                lat= Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Introduceti adancimea cubului nr " + j);
                                ad= Convert.ToDouble(Console.ReadLine());
                                cutii[j - 1]=new Cutie(lun, lat, ad);
                            }
                            i += c;
                            Console.ReadKey();
                            break;
                        }
                    case "l":
                        {
                            for(int j=0;j<i;j++)
                            {
                                cutii[j].ConversieLaSir();
                            }
                            Console.ReadKey();
                            break;
                        }
                    case "f":
                        {

                            Console.ReadKey();
                            break;
                        }
                    case "c":
                        {
                            Console.ReadKey();
                            break;
                        }
                    case "x":
                        return;
                }
                Console.WriteLine("\nAlege o optiune");
            } while (true);
        }
    }
   
}
