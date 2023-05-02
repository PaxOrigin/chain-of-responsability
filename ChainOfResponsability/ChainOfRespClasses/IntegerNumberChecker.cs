namespace ChainOfRespClasses;

public class IntegerNumberChecker : Checker
{
    public IntegerNumberChecker(Checker? nextChecker = null) : base(nextChecker)
    {

    }

    public override (bool, string) Check(List<string> values)
    {


        var hasNegatives = values.Select(p => int.Parse(p)).Any(p => p < 0);
        if (hasNegatives)
            return (false, "string contains negative numbers");
        if (_nextChecker is not null)
            return _nextChecker.Check(values);
        return (true, "string is valid");
    }
}
