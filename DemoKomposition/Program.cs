using DemoKomposition;

MovieCreator movieCreator = new MovieCreator();

for (int i = 0; i < movieCreator.AllGenres.Count; i++)
{
    Console.WriteLine(i + ". " + movieCreator.AllGenres[i].Name);
}

string input = Console.ReadLine();
//Alla genres separerade med kommatecken
var choices = input.Split(',');
int[] choiceIndices = new int[choices.Length];
for (int i = 0; i < choices.Length; i++)
{
    choiceIndices[i] = int.Parse(choices[i]);
}

for (int i = 0; i < movieCreator.Directors.Count; i++)
{
    Console.WriteLine(i + ". " + movieCreator.Directors[i].Name);
}

string input2 = Console.ReadLine();

int directorChoice = int.Parse(input2);

Movie jurassicPark = movieCreator.BuildMovie("Jurassic Park", "RAWR!", choiceIndices, directorChoice);


Console.WriteLine(jurassicPark.Genres.Count);