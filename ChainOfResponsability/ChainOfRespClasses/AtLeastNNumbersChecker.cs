namespace ChainOfRespClasses;

public class AtLeastNNumbersChecker : Checker
{
    private readonly int _numbersToHave;

    public AtLeastNNumbersChecker(Checker? checker, int numbersToHave = 2) : base(checker)
    {
        _numbersToHave = numbersToHave;
    }

    public override (bool, string) Check(List<string> values)
    {
        int numbersFound = values.Select(p => int.Parse(p)).Count();

        if (numbersFound >= _numbersToHave && _nextChecker is not null)
            return _nextChecker.Check(values);
        if (numbersFound >= _numbersToHave && _nextChecker is null)
            return (true, $"The string is valid.");
        return (false, $"The string does not have at least {_numbersToHave} numbers");

    }
}
