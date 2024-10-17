namespace Grupp7Git
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static List<string> inventory = new List<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Fabrikshanteringssystemet!");
            while (true)
            {
                Console.WriteLine("\nVälj en åtgärd:");
                Console.WriteLine("1. Lägg till produkt");
                Console.WriteLine("2. Visa inventarie");
                Console.WriteLine("3. Avsluta");
                string val = Console.ReadLine();
                switch (val)
                {
                    case "1":
                        LäggTillProdukt();
                        break;
                    case "2":
                        VisaInventarie();
                        break;
                    case "3":
                        return;
                    case "4":
                        SökProdukt();
                        return;

                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }

            }
        }
        static void LäggTillProdukt()
        {
            // TODO: Implementera metod för att lägga till produkt
            Console.WriteLine("ange produktens namn");
            string inventory = Console.ReadLine();
        }
        static void VisaInventarie()
        {
            // TODO: Implementera metod för att visa inventarie
        }
       
            
            static void SökProdukt()
            {
                Console.Write("Skriv namnet på produkten du vill söka efter: ");
                string sökProdukt = Console.ReadLine();

                
                if (inventory.Contains(sökProdukt))
                {
                    Console.WriteLine($"Produkten '{sökProdukt}' finns i listan.");
                }
                else
                {
                    Console.WriteLine($"Produkten '{sökProdukt}' hittades inte.");
                }
            }
        }
    }

    

