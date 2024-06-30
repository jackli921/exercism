using System;
using System.Linq;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        Direction = direction;
        X = x;
        Y = y;
    }
    public Direction Direction { set; get; }

    public int X { set; get; }
    public int Y { get; set; }
    
    public void Move(string instructions)
    {
        foreach (var step in instructions)
        {
            switch (step)
            {
                case 'R': MoveRight(); break;
                case 'L': MoveLeft(); break;
                case 'A': Advance(); break;
                default: throw new ArgumentException("Invalid Move");
            }    
        }
    }

    public void MoveRight() =>
        Direction = Direction switch
        {
            Direction.North => Direction.East,
            Direction.East => Direction.South,
            Direction.South => Direction.West,
            Direction.West => Direction.North,
            _ => throw new ArgumentException("Invalid Direction")
        };

    public void MoveLeft() =>
        Direction = Direction switch
        {
            Direction.North => Direction.West,
            Direction.West => Direction.South,
            Direction.South => Direction.East,
            Direction.East => Direction.North,
            _ => throw new ArgumentException("Invalid Direction")
        };

    public void Advance() => (X, Y) = Direction switch
        {
            Direction.North => (X, Y + 1),
            Direction.East => (X + 1, Y),
            Direction.South => (X, Y - 1),
            Direction.West => (X - 1, Y),
            _ => throw new ArgumentException("Invalid Direction")
        };
}