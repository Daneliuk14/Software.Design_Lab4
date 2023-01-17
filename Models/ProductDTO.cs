namespace Software.Design.Models;

public class KeyboardDTO
{
    public int manufacturerid { get; set; }
    public string name { get; set; } = default!;
    public Boolean backlight { get; set; }
    public string colour { get; set; } = default!;
}