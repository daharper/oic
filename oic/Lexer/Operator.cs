using System.Collections.Generic;

namespace oic.Lexer
{
    public class Operator : Token
    {
        public Operator(string symbol) : base(symbol) { }

        public static bool IsOperator(string symbol) => Operators.Contains(symbol);

        private static readonly List<string> Operators = new List<string>
        {
            "="
        };
    }
}
