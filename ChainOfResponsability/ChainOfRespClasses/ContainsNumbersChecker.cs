namespace ChainOfRespClasses;

public class ContainsNumbersChecker : Checker
{
    public ContainsNumbersChecker(Checker checker) : base(checker)
    {

    }

    public override (bool, string) Check(List<string> value)
    {
        if (value.All(p => string.IsNullOrWhiteSpace(p)))
            return (false, "String is empty");

        var listOfNumbers = value.Where(p => int.TryParse(p, out _)).ToList();
        if (_nextChecker is not null)
            return _nextChecker.Check(listOfNumbers);
        return (true, "Valid list");
    }
}
