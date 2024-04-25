namespace Soucet_dvou_cisel
{
//    Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj, sečtu ti dvě čísla");

            int prvniCislo = GetInputFromUser("Zadej první číslo");
            int druheCislo = GetInputFromUser("Zadej druhé číslo");


            Console.WriteLine($"Součet zadaných čísel {prvniCislo} a {druheCislo}je: {prvniCislo + druheCislo}");
            int GetInputFromUser(string message)
            {
                int value;
                bool isNumber;
                do
                {
                    Console.WriteLine(message);
                    string? input = Console.ReadLine();
                    isNumber = int.TryParse(input, out value);
                } while (isNumber is false);

                return value;
            }
            Console.WriteLine();
            return;

            
        }
    }
}
