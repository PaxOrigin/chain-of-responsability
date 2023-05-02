namespace ChainOfRespClasses
{
    public abstract class Checker
    {
        protected Checker? _nextChecker;

        public Checker(Checker? nextChecker)
        {
            _nextChecker = nextChecker;
        }

        public abstract (bool, string) Check(List<string> value);
    }
}