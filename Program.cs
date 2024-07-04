namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "TicTacToe 1.0";

        while (true) 
        {
            Console.Clear();
            Console.WriteLine("------ TicTacToe 1.0 ------");
            Console.WriteLine("1. Player vs Player");
            Console.WriteLine("2. Player vs Random");
            Console.WriteLine("3. Random vs Player");
            Console.WriteLine("4. Player vs AI");
            Console.WriteLine("5. AI vs Player");
            Console.WriteLine("6. Simulate Random vs Random");
            Console.WriteLine("7. Simulate AI vs Random");
            Console.WriteLine("8. Simulate Random vs AI");
            Console.WriteLine("9. Simulate AI vs AI");
            Console.WriteLine("0. Exit");
        }
    }

    static void PlayGame() 
    {
        // Console.WriteLine()
        Console.ResetColor();
    }
}
