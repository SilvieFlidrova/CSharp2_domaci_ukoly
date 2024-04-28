namespace Hadani_cisla
{
    internal class Program
    {
        // Napište program, který umožní hádat číslo.Zeptá se, jaké číslo si myslím.Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
        //Např.
        //Hádej číslo: 10
        //Číslo je menší, hádej znovu: 5
        //Číslo je větší, hádej znovu: 7
        //To je správně!
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, pojď hádat čísla!");

            Random nh = new Random();
            int cisloSpravne = nh.Next(0, 101);

           // Console.WriteLine(cisloSpravne);

            Console.WriteLine("zadej svůj tip od 0 do 100:");
           
            bool uhadlJsi = false;
            int pocetPokusu = 1;

            while (!uhadlJsi)
            {
                int tip = int.Parse(Console.ReadLine());

                if (tip> cisloSpravne)
                {
                    Console.WriteLine("tip je moc velký, zadej nový tip:");
                    pocetPokusu++;
                }
                else if (tip < cisloSpravne)
                {
                    Console.WriteLine("tip je moc malý, zadej nový tip:");
                    pocetPokusu++;
                }
                else
                {
                    Console.WriteLine($"gratuluji, číslo {cisloSpravne} jsi uhádl na {pocetPokusu}. pokus :)");
                    uhadlJsi = true;
                }
            }

        }
    }
}
