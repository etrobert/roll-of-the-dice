public readonly struct BoardPosition {
    public BoardPosition(int x, int y) {
        X = x;
        Y = y;
    }

    public int X { get; init; }
    public int Y { get; init; }

    public static bool operator ==(BoardPosition b1, BoardPosition b2)
    {
        return b1.Equals(b2);
    }

    public static bool operator !=(BoardPosition b1, BoardPosition b2)
    {
        return !b1.Equals(b2);
    }

    public BoardPosition Right()
    {
        return new BoardPosition(X + 1, Y);
    }
}
