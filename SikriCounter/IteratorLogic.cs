namespace SikriCounter
{
    public sealed class IteratorLogic
    {
        public static string GenerateNumberOutput(int index, IEnumerable<IIteratorRule> rules) =>
            rules.Where(rule => rule.IsMatch(index))
                 .Select(y => y.Output)
                 .DefaultIfEmpty("")
                 .Aggregate((a, b) => $"{a}{b}");
    }
}
