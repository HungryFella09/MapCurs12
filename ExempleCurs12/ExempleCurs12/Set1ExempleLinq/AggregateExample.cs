namespace ExempleCurs12;

public class AggregateExample
{
    //Aplica o operatie pentru fiecare element al colectiei, tinand resultatul in continuare

    public static void Example()
    {
        string[] duckNames = { "Petra", "Rudky", "Rata", "Marghiola", "Jim"};
        string longestName = duckNames.Aggregate((longest, next) => longest.Length > next.Length ? longest : next);
        Console.WriteLine("Longest Name: {0}", longestName);
    }
    
}