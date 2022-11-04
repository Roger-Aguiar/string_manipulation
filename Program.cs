class Program
{
    private static void Main(string[] args)
    {
        var frequencies = new List<Frequencies>();

        string [] result = {"02 03 07 08 09 10 12 13 14 15 17 18 19 20 21",
                            "01 03 04 05 06 08 10 12 14 15 16 17 19 24 25",
                            "03 04 10 11 12 13 15 16 17 18 19 22 23 24 25"};
        
        for (int number = 1; number <= 25; number++)
        {
            var numberLayout = number.ToString("00");
            var frequencyChecker = new FrequencyChecker(numberLayout, result);
            frequencies.Add(new Frequencies{Number = numberLayout, Frequency = frequencyChecker.GetFrequency()});
        }

        var lotofacil = new Lotofacil(frequencies);
        var myGuess = lotofacil.CreateGame();

        Console.WriteLine(myGuess);
        Console.ReadLine();
    }
}