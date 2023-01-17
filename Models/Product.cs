namespace Software.Design.Models;

public class Keyboard
{
    public Keyboard()
    {
    }

    public Keyboard(KeyboardDTO keyboardDTO)
    {
        manufacturerid = keyboardDTO.manufacturerid;
        name = keyboardDTO.name;
        backlight = keyboardDTO.backlight;
        colour = keyboardDTO.colour;
    }

    public int id { get; set; }
    public int manufacturerid { get; set; }
    public string name { get; set; } = default!;
    public Boolean backlight { get; set; }
    public string colour { get; set; } = default!;
}