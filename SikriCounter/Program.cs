using SikriCounter;
using SikriCounter.Rules;

IEnumerable<int> sequence = Enumerable.Range(1, 100);
IEnumerable<IRule> rules = new IRule[2] { new OddRule("Odd"), new DivisorRule(7, "Seven") };

Console.WriteLine("--- START ---");
foreach (var index in sequence)
{
    var output = IteratorLogic.GenerateNumberOutput(index, rules);

    if (string.IsNullOrEmpty(output))
        continue;
    
    Console.WriteLine(index + ": " + output);
}
Console.WriteLine("---- END ----");