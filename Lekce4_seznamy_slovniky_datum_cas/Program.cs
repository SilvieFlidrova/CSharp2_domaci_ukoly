using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lekce4_seznamy_slovniky_datum_cas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            DateTime aktualni = DateTime.Now;
            Console.WriteLine($" Aktuální den: {aktualni}");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
            DateTime datumNarozeni = new DateTime(1974, 9, 11);

            double odecetCasu = (aktualni - datumNarozeni).TotalDays;
            int dnyMehoZivota =(int) Math.Round(odecetCasu) ;
            Console.WriteLine($"Už jsem na světě {dnyMehoZivota} dnů.");
            
            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.

            // 4. Smaž z tohoto listu libovolnou hodnotu.

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.


        }
    }
}
