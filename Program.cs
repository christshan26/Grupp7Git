using System;

using System.Collections.Generic;

class Program
  
{
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


