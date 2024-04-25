namespace Hvezdicky
{
    internal class Program
    {
        //Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj! Když mi zadáš počet hvězdiček, vykreslím je");

            Console.WriteLine("zadej počet hvězdiček:");
            string zadanyPocetHvezdicek = Console.ReadLine();
            int pocetHvezdicek;
            bool jeCislo = int.TryParse(zadanyPocetHvezdicek, out pocetHvezdicek);
            if (!jeCislo)
            {
                Console.WriteLine("Nezadal jsi platné číslo");
            };

            for (int i = 1; i <= pocetHvezdicek; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
