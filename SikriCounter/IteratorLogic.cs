using SikriCounter.Rules;

namespace SikriCounter
{
    public sealed class IteratorLogic
    {
        public static string GenerateNumberOutput(int index, IEnumerable<IRule> rules) =>
            rules.Where(rule => rule.IsMatch(index))
                 .Select(y => y.Output)
                 .DefaultIfEmpty("")
                 .Aggregate((a, b) => $"{a}{b}");
    }
}
