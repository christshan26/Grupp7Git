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

                    TaBortProdukt();
                    break;

                case "4":

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
}

