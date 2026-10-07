namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Divide(8,2)}");
        }

        static int Add(int x, int y) {return x + y;}
        static int Divide(int x, int y) { return x / y; }
    }
}