namespace GIP.Warehouse;

public class TouchScreen
{
    public float Width { get; set; }
    public float Height { get; set; }
    public float Dpi { get; set; }

    public override string ToString()
    {
        return $"{Width}x{Height} {Dpi}";
    }
}
