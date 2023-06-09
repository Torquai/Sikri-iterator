﻿namespace SikriCounter.Rules
{
    public class OddRule : IRule
    {
        public OddRule(string output)
        {
            Output = output;
        }

        public string Output { get; private set; }

        public bool IsMatch(int value) => value % 2 != 0;
    }
}
