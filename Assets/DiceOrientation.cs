namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}

public readonly struct DiceOrientation
{
    public DiceOrientation(int top, int bottom, int left, int right, int front, int back)
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

    public DiceOrientation RotateLeft()
    {
        return new DiceOrientation(Right, Left, Top, Bottom, Front, Back);
    }

    public DiceOrientation RotateRight()
    {
        return new DiceOrientation(Left, Right, Bottom, Top, Front, Back);
    }

    public DiceOrientation RotateFront()
    {
        return new DiceOrientation(Back, Front, Left, Right, Top, Bottom);
    }

    public DiceOrientation RotateBack()
    {
        return new DiceOrientation(Front, Back, Left, Right, Bottom, Top);
    }
}
