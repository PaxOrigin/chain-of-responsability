namespace ChainOfRespClasses;

public static class Parser
{
    public static List<string> ParseString(string input) => input.Split(',').ToList();
}
