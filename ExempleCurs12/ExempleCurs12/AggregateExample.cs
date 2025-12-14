namespace ExempleCurs12;

public class AggregateExample
{
    //Performs a specified operation to each element in a collection, while carrying the result forward.
    //Aplica o operatie pentru fiecare element al colectiei, tinand resultatul in continuare

    public static void Example()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var result = numbers.Aggregate((result, next) => result * next);
        Console.WriteLine("Aggregated numbers by multiplication:");
        Console.WriteLine(result);
    }

    public static void Exercise()
    {
        //Se da o lista de nume de rate, printati numele cel mai lung
        string[] duckNames = { "Petra", "Rudky", "Rata", "Marghiola", "Jim"};
        
        //TODO
        string longestName = "";

        Console.WriteLine("Longest Name: {0}", longestName);
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public static void ResolvedExercise()
    {
        string[] duckNames = { "Petra", "Rudky", "Rata", "Marghiola", "Jim"};
        string longestName = duckNames.Aggregate((longest, next) => longest.Length > next.Length ? longest : next);
        Console.WriteLine("Longest Name: {0}", longestName);
    }
    
}