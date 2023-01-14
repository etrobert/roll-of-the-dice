namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}

public readonly struct DicePosition
{
    public DicePosition(int top, int bottom, int left, int right, int front, int back)
    {
        Top = top;
        Bottom = bottom;
        Left = left;
        Right = right;
        Front = front;
        Back = back;
    }

    public int Top { get; init; }
    public int Bottom { get; init; }
    public int Left { get; init; }
    public int Right { get; init; }
    public int Front { get; init; }
    public int Back { get; init; }

    public DicePosition RotateLeft()
    {
        return new DicePosition(Right, Left, Top, Bottom, Front, Back);
    }

    public DicePosition RotateRight()
    {
        return new DicePosition(Left, Right, Bottom, Top, Front, Back);
    }

    public DicePosition RotateFront()
    {
        return new DicePosition(Back, Front, Left, Right, Top, Bottom);
    }

    public DicePosition RotateBack()
    {
        return new DicePosition(Front, Back, Left, Right, Bottom, Top);
    }
}
