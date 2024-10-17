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
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
            }
        }
        static void LäggTillProdukt()  // AZAT
        {
            Console.WriteLine("ange produktens namn");
            string addedInventory = Console.ReadLine();  // Läser in produkten som användaren vill lägga till.
            inventory.Add(addedInventory);  // Lägger till produkten i listan inventory.
        }
        static void VisaInventarie()  // CHRISTOFFER
        {
            Console.WriteLine("Aktuellt inventarie: \n");
            foreach (string item in inventory)  // Loopar igenom hela listan inventory.
            {
                Console.WriteLine(item); // Skriver ut alla produkter som hittas i inventory.
            }
        }
        static void TaBortProdukt()  // ALBIN
        {
            Console.WriteLine("Vilken produkt vill du ta bort?");
            String? eraseProduct = Console.ReadLine(); // Läser in produkten som användaren vill ta bort.

            if (inventory.Contains(eraseProduct))  // If-sats som kollar ifall produkten finns i listan.
            {
                inventory.Remove(eraseProduct);  // Tar bort produkten från listan.
                Console.WriteLine($"{eraseProduct} har tagits bort");
            }
            else  // Else som körs ifall produkten inte hittas i listan.
            {
                Console.Write("Skriv namnet på produkten du vill söka efter: ");
            }
        }

        static void SökProdukt()  // RASHIID
        {
            Console.Write("Skriv namnet på produkten du vill söka efter: ");
            string sökProdukt = Console.ReadLine();  // Läser in produkten som användaren vill hitta.


            if (inventory.Contains(sökProdukt)) // If-sats som kollar ifall produkten finns i listan.
            {
                Console.WriteLine($"Produkten '{sökProdukt}' finns i listan.");  //Skriver ut produkten.
            }
            else
            {
                Console.WriteLine($"Produkten '{sökProdukt}' hittades inte.");  // Else som körs ifall produkten inte hittas i listan.
            }
        }
    }
}
       