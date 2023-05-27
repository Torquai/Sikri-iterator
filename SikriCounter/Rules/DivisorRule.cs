using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SikriCounter.Rules
{
    public sealed class DivisorRule : IIteratorRule
    {
        private int _divisor;

        public DivisorRule(int divisor, string output)
        {
            _divisor = divisor;
            Output = output;
        }

        public string Output { get; private set; }

        public bool IsMatch(int value) => value % _divisor == 0;
    }
}
