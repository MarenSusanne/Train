namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Game game = new Game();
            game.RunTrain(train);
        }
    }
}
