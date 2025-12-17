namespace ExempleCurs12.Set3ExempleLinq;

public class Exercitiu3
{
    public static void Run()
    {
        OtherDuck[] OtherDucks =
        {
            new OtherDuck("OtherDuck1", 5L),
            new OtherDuck("OtherDuck5",3L),
            new OtherDuck("OtherDuck2",3L),
            new OtherDuck("OtherDuck3",4L),
            new OtherDuck("OtherDuck4",2L)
        };


        Child[] children =
        {
            new Child("Andrei", 3L),
            new Child("Malina", 4L),
            new Child("Ana", 2L)
        };
        

        // Sa se determine numele ratelor care trimit cadouri copiilor din lista, dar si
        // numele copiilor. Rezultatul va fi ordonat dupa numele copiilor, iar mai apoi dupa numele ratelor.


        // SINTAXA QUERY
        //var join1 =
        //TODO

        // SINTAXA METHOD
        //var join2  = 
        //TODO



        //foreach (var j in join2)
        //    Console.WriteLine(String.Format("Duck name: {0}, child name: {1}", j.duckName, j.childName));

    }
}