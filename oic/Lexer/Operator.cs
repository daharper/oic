using System.Collections.Generic;

namespace oic.Lexer
{
    public class Operator : Token
    {
        public Operator(string symbol, int lineNumber) : base(symbol, lineNumber) { }

        public static bool IsOperator(string symbol) => Operators.Contains(symbol);

        private static readonly List<string> Operators = new List<string>
        {
            "="
        };
    }
}
