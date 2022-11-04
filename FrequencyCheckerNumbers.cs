public class FrequencyChecker
{
    private string? Number { get; init; }
    private string? [] Results { get; init; }

    public FrequencyChecker(string number, string[] results)
    {
        Number = number;
        Results = results;
    }

    public int GetFrequency()
    {     
        var frequency = 0;   
        for (int i = 0; i < Results.Count(); i++)
        {
            if (Results[i].Contains(Number))
            {
                frequency++;
            }                
        }     
        return frequency;   
    }

    
}