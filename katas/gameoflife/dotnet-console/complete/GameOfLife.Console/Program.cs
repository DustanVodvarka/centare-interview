namespace GameOfLife.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(Demos.Exploder.InitialState);
            game.Start(Demos.Exploder.Iterations);

            System.Console.WriteLine();
            System.Console.WriteLine("Hit any key to exit");
            System.Console.ReadKey();
        }
    }
}
