public class Lotofacil
{
    public List<Frequencies>? Frequencies { get; set; }

    public Lotofacil(List<Frequencies> frequencies)
    {
        Frequencies = frequencies;
    }

    public string CreateGame()
    {
        List<string> myGame = new List<string>();
        string myGameLayout = "";

        var allNumbers = SortByFrequency();

        for (int index = 0; index < 15; index++)
        {
            myGame.Add(allNumbers[index].Number);
        }
        myGame.Sort();

        foreach (var item in myGame)
        {
            myGameLayout += $"{item} ";
        }

        return myGameLayout;
    }

    public List<Frequencies> SortByFrequency()
    {
        var frequenciesSorted = Frequencies?.OrderBy(o => o.Frequency).ToList();
        frequenciesSorted?.Reverse();
        return frequenciesSorted;
    }
}