namespace pixel_flash_remake;

public partial class Form1 : Form
{
    private Bitmap? _bitmap;
    private Graphics? _graphics;

    public Form1()
    {
        InitializeComponent();
        SetupCanvas();
        DrawImage();
    }

    private void SetupCanvas()
    {
        _bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
        _graphics = Graphics.FromImage(_bitmap);
        pictureBox.Image = _bitmap;
    }

    private void DrawImage()
    {
        var pen = new Pen(Color.Black, 1);
        var brushYellow = new SolidBrush(Color.FromArgb(255, 255, 0));
        var brushWhite = new SolidBrush(Color.FromArgb(255, 255, 255));
        var brushBlack = new SolidBrush(Color.FromArgb(0, 0, 0));
        var brushRed = new SolidBrush(Color.FromArgb(255, 0, 0));
        var brushSkin = new SolidBrush(Color.FromArgb(244, 164, 96));


        PaintedArea[] data =
        [
            new PaintedArea(pen, brushYellow, AreaData.yellowLightning),
            new PaintedArea(pen, brushYellow, AreaData.yellowLightning2),
            new PaintedArea(pen, brushYellow, AreaData.yellowSoak),
            new PaintedArea(pen, brushYellow, AreaData.yellowSoak2),
            new PaintedArea(pen, brushYellow, AreaData.handBelts),
            new PaintedArea(pen, brushWhite, AreaData.belly),
            new PaintedArea(pen, brushWhite, AreaData.belly1),
            new PaintedArea(pen, brushWhite, AreaData.belly2),
            new PaintedArea(pen, brushWhite, AreaData.eye),
            new PaintedArea(pen, brushWhite, AreaData.eyeMouth),
            new PaintedArea(pen, brushBlack, AreaData.blackRight),
            new PaintedArea(pen, brushBlack, AreaData.blackLeft),
            new PaintedArea(pen, brushBlack, AreaData.eye1),
            new PaintedArea(pen, brushBlack, AreaData.blackNeck),
            new PaintedArea(pen, brushRed, AreaData.redHead),
            new PaintedArea(pen, brushRed, AreaData.redBelt),
            new PaintedArea(pen, brushRed, AreaData.redHandLeft),
            new PaintedArea(pen, brushRed, AreaData.redHandRight),
            new PaintedArea(pen, brushRed, AreaData.redShoulder),
            new PaintedArea(pen, brushRed, AreaData.redLastFinally),
            new PaintedArea(pen, brushBlack, AreaData.blackBootLeft),
            new PaintedArea(pen, brushBlack, AreaData.blackBootRight),
            new PaintedArea(pen, brushSkin, AreaData.mouth),
            new PaintedArea(pen, brushBlack, AreaData.blackParts),
        ];

        foreach (var paintedArea in data)
        {
            if (_graphics == null)
            {
                return;
            }

            DrawArea(_graphics, paintedArea);
            FillArea(_graphics, paintedArea);
        }
    }


    private void DrawArea(Graphics graphics, PaintedArea paintedArea)
    {
        if (paintedArea.Points != null)
        {
            graphics.DrawPolygon(paintedArea.Pen, paintedArea.Points);
        }
        else if (paintedArea.Rectangles != null)
        {
            graphics.DrawRectangles(paintedArea.Pen, paintedArea.Rectangles);
        }
    }

    private void FillArea(Graphics graphics, PaintedArea paintedArea)
    {
        if (paintedArea.Points != null)
        {
            graphics.FillPolygon(paintedArea.Brush, paintedArea.Points);
        }
        else if (paintedArea.Rectangles != null)
        {
            graphics.FillRectangles(paintedArea.Brush, paintedArea.Rectangles);
        }
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        _graphics?.Dispose();
        _bitmap?.Dispose();
        base.OnFormClosing(e);
    }
}