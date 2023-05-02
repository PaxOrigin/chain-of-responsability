namespace ChainOfRespClasses;

public static class ChainBuilder
{
    public static Checker GetChain()
    {
        Checker integerChecker = new IntegerNumberChecker();
        Checker isNumberChecker = new AtLeastNNumbersChecker(integerChecker);
        Checker ContainsNumbers = new ContainsNumbersChecker(isNumberChecker);
        return ContainsNumbers;
    }
}
