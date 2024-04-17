namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortCharacter sortCharacter = new SortCharacter();
            Psbb psbb = new Psbb();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine(" 1. Sort Character ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            sortCharacter.run();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~~~~~ 2. PSBB ~~~~~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
            psbb.run();
        }
    }
}
