﻿namespace Grupp7Git
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
                Console.WriteLine("3. Ta bort produkt");
                Console.WriteLine("4. Sök produkt");
                Console.WriteLine("5. Avsluta");
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
                        //TaBortProdukt();
                        break;
                    case "4":
                        //SökProdukt();
                        break;
                    case "5":
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
        }
        static void VisaInventarie()
        {
            // TODO: Implementera metod för att visa inventarie
            foreach (string item in inventory)
            {
                Console.WriteLine("Aktuellt inventarie: ");
                Console.WriteLine($"\n{item}");
            }
        }
    }
}
