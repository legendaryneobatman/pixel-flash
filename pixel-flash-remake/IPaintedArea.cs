namespace pixel_flash_remake;

public interface IPaintedArea
{
    Pen Pen { get; }
    Brush Brush { get; }
    Point[] Points { get; }
    Rectangle[]? Rectangles { get; }
}