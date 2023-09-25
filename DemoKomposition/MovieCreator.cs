namespace DemoKomposition;

public class MovieCreator
{
    public List<Genre> AllGenres { get; set; }
    public List<Director> Directors { get; set; }

    public MovieCreator()
    {
        AllGenres = new List<Genre>()
        {
            new Genre("SciFi","Best genre of all time!"),
            new Genre("Horror", "Worst genre of all time!"),
            new Genre("Comedy", "A genre!")
        };

        Directors = new List<Director>()
        {
            new Director(){ Name = "George Lucas" },
            new Director(){ Name = "James Cameron" },
            new Director(){ Name = "Steven Spielberg" }
        };
    }

    public Movie BuildMovie(string name, string description, int[] genreIndices, int directorIndex)
    {
        Movie movie = new Movie();
        movie.Name = name;
        movie.Description = description;
        movie.Director = Directors[directorIndex];
        foreach (var genreIndex in genreIndices)
        {
            movie.Genres.Add(AllGenres[genreIndex]);
        }
        return movie;
    }
}