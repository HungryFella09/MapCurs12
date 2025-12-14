namespace ExempleCurs12;

public class ElementAtOrDefaultExample
{
    //Returneaza elementul la indexul specificat sau valuarea default daca valoarea este out of range
    
    public static void Example()
    {
        string[] colors = { "Red", "Green", "Blue" };
        var resultIndex1 = colors.ElementAtOrDefault(1);
        Console.WriteLine("Element at index 1 in the array contains: {0}", resultIndex1);
        
        var resultIndex10 = colors.ElementAtOrDefault(10);
        Console.WriteLine("Element at index 10 does not exist: {0}", resultIndex10 == null);

        //asta ar arunca exceptie in mod normal
        //Console.WriteLine(colors[10]);
    }
}

