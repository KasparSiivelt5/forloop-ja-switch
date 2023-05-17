using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vali üks järgmistest valikutest:");
        Console.WriteLine("1. Küsi nimi");
        Console.WriteLine("2. Küsi vanus");
        Console.WriteLine("3. Kontrolli õpperühma");

        int valik = Convert.ToInt32(Console.ReadLine());

        switch (valik)
        {
            case 1:
                KysiNimi();
                break;
            case 2:
                KysiVanus();
                break;
            case 3:
                KontrolliOppegruppi();
                break;
            default:
                Console.WriteLine("Vigane valik!");
                break;
        }
    }

    static void KysiNimi()
    {
        Console.WriteLine("Sisesta oma nimi:");
        string nimi = Console.ReadLine();
        Console.WriteLine("Sinu nimi on: " + nimi);
    }

    static void KysiVanus()
    {
        Console.WriteLine("Sisesta oma vanus:");
        int vanus = Convert.ToInt32(Console.ReadLine());

        if (vanus < 18)
        {
            Console.WriteLine("Oled alaealine.");
        }
        else
        {
            Console.WriteLine("Oled täisealine.");
        }
    }

    static void KontrolliOppegruppi()
    {
        Console.WriteLine("Sisesta oma õpperühm:");
        string rühm = Console.ReadLine();

        if (rühm == "TITpe22")
        {
            Console.WriteLine("Oled õiges rühmas.");
        }
        else
        {
            Console.WriteLine("Ei kuulu õigesse rühma.");
        }
    }
}
