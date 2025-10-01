using pixel_flash_remake.Types;

namespace pixel_flash_remake;

public class PaintedArea() : IPaintedArea
{
    public Pen Pen { get; }
    public Brush Brush { get; }
    public Point[]? Points { get; }
    public Rectangle[]? Rectangles { get; }

    public PaintedArea(Pen pen, Brush brush, PolygonSequence sequence) : this()
    {
        Pen = pen;
        Brush = brush;
        Points = GetPointsFromPolygon(sequence);
    }

    public PaintedArea(Pen pen, Brush brush, RectangleSequence sequence) : this()
    {
        Pen = pen;
        Brush = brush;
        Rectangles = GetPointsFromRectangle(sequence);
    }

    private static Point[] GetPointsFromPolygon(PolygonSequence sequence)
    {
        return sequence.Select(p => new Point(p.Item1, p.Item2)).ToArray();
    }

    private static Rectangle[] GetPointsFromRectangle(RectangleSequence sequence)
    {
        return sequence.Select(p => new Rectangle(p.Item1, p.Item2, p.Item3, p.Item4)).ToArray();
    }
}