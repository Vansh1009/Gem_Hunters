using System;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        game.Start();
    }
}
