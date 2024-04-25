namespace Hadej_cilso
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
            int cisloSpravne = nh.Next(0, 100);
            Console.WriteLine("zedej svůj tip od 0 do 100:");
            bool uhadlJsi = false;

            while (!uhadlJsi)
            {
                string zadanyTip = Console.ReadLine();

                int tip = int.Parse(zadanyTip);

                if (tip > cisloSpravne)
                {
                    Console.WriteLine("tip je moc velký, zadej nový tip:");
                   
                }
                else if (tip < cisloSpravne)
                {
                    Console.WriteLine("tip je moc malý, zadej nový tip:");
                    
                }
                else
                {
                    Console.WriteLine("uhádl jsi, gratuluji");
                    uhadlJsi = true;
                }
            }
            
           

            
                
            
            
        }
    }
}
