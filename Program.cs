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
                        TaBortProdukt();
                        break;
                    case "4":
                        SökProdukt();
                        break;

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
            foreach (string item in inventory)
            {
                Console.WriteLine("Aktuellt inventarie: ");
                Console.WriteLine($"\n{item}");
            }
        }


        
        static void TaBortProdukt()
        {
            Console.WriteLine("Vilken produkt vill du ta bort?");
            String? eraseProduct = Console.ReadLine();

            if (inventory.Contains(eraseProduct))
            {
                inventory.Remove(eraseProduct);
                Console.WriteLine($"{eraseProduct} har tagits bort");
            }
            else
            {
                Console.WriteLine($"{eraseProduct} finns inte i listan");
            }

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

    

