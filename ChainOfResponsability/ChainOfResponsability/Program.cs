namespace ChainOfResponsability;

using ChainOfRespClasses;

using static ChainOfRespClasses.Parser;

public class Program
{
    static void Main(string[] args)
    {

        string value1 = "1,2";
        string value2 = "a,2";
        string value3 = "1,-2";
        string value4 = "1,";
        string value5 = "1,b";
        string value6 = "2, 4, aaaaa, 3, 555,-3,2";
        string value7 = " ,2";
        string value8 = "";

        Checker checker = ChainBuilder.GetChain();

        List<string> stringsToCheck = new List<string>()
        { value1,
          value2,
          value3,
          value4,
          value5,
          value6,
          value7,
          value8
        };

        foreach (var item in stringsToCheck)
        {
            var parsedItem = ParseString(item);
            Console.WriteLine(checker.Check(parsedItem).Item2);
        }
    }
}