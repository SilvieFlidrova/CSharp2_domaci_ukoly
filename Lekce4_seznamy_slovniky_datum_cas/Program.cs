using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lekce4_seznamy_slovniky_datum_cas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Vypis(List<string> pocetPsu) => pocetPsu.ForEach(Console.WriteLine);

            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.

            DateTime aktualni = DateTime.Now.Date;
            Console.WriteLine($" Aktuální den: {aktualni}");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození. Potom vypiš, kolik dnů od té doby uteklo.
           
            DateTime datumNarozeni = new DateTime(1974, 9, 11);
            double odecetCasu = (aktualni - datumNarozeni).TotalDays;
            Console.WriteLine($"Už jsem na světě {odecetCasu} dní.");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> plemenaPsu = new List<string> { "kokršpanel", "jezevcik", "pitbull", "pudl", "civava" };
            Vypis(plemenaPsu);
            Console.WriteLine();

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            plemenaPsu.Remove("civava");
            Vypis(plemenaPsu);
            Console.WriteLine();

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            if (plemenaPsu.Contains("pudl"))
            {
                Console.WriteLine("obsahuje");
            }

            else
            {
                Console.WriteLine("neobsahuje");

            }
            Console.WriteLine();

            // 6. Vypiš do konzole, kolik je v tom listu prvků a připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").

            Console.Write($"{plemenaPsu.Count}: ");
            for (int i = 0; i < plemenaPsu.Count; i++)
            {
                Console.Write($"{plemenaPsu[i]}, ");
            }
            Console.WriteLine();
            Console.Write($"{plemenaPsu.Count}: ");
            foreach(string item in plemenaPsu)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string) a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, double> nakupniTaska = new Dictionary<string, double>()
            {
                {"chleba", 20},
                {"rohlik", 2},
                {"bageta", 15},
            };

            foreach (var item in nakupniTaska)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine();

            bool nakupuji = true;
            while (nakupuji)
            {


                // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.

                Console.WriteLine("zadej potravinu:");
                string potravina = Console.ReadLine();

                if (potravina != "")
                {

                    double cenaPotraviny;
                    if (nakupniTaska.TryGetValue(potravina, out cenaPotraviny))
                    {
                        Console.WriteLine($" cena potraviny: {potravina} je {cenaPotraviny} Kc.");
                    }
                    else
                    {
                        Console.WriteLine($"{potravina} neni v ceniku.");
                    }
                }
                
                // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila, že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak, aby obsahovala hromadnou cenu za všechny stejné položky.
                Console.WriteLine("zadej potravinu, kterou chces pridat do kosiku a poté její cenu:");
                string pridavanaPotravina = Console.ReadLine();

                if (pridavanaPotravina != "")
                {
                    int cenaPridavanePotraviny = int.Parse(Console.ReadLine());

                    if (!nakupniTaska.TryAdd(pridavanaPotravina, cenaPridavanePotraviny))
                    {

                        nakupniTaska[pridavanaPotravina] += cenaPridavanePotraviny;
                    }
                }
                else
                {
                    nakupuji = false;
                }

               
            }
            Console.WriteLine("Obsah nákupní tašky:");
            foreach (var item in nakupniTaska)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine();
        }
    }
}
