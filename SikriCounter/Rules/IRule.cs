namespace SikriCounter.Rules
{
    public interface IRule
    {
        bool IsMatch(int value);
        string Output { get; }
    }
}
