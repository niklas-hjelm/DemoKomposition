namespace DemoKomposition;

public class Movie
{
    public Director Director { get; set; }

    public List<Genre> Genres { get; set; } = new List<Genre>();

    public string Name { get; set; }

    public string Description { get; set; }
}