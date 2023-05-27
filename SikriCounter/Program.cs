using SikriCounter;

IEnumerable<int> sequence = Enumerable.Range(1, 100);
IEnumerable<IIteratorRule> rules = new IIteratorRule[2] { new OddRule("Odd"), new DivisorRule(7, "Seven") };

Console.WriteLine("--- START ---");
foreach (var index in sequence)
{
    var output = IteratorLogic.GenerateNumberOutput(index, rules);

    if (string.IsNullOrEmpty(output))
        continue;
    
    Console.WriteLine(index + ": " + output);
}
Console.WriteLine("---- END ----");