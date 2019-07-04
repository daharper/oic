using System.Collections.Generic;

namespace oic.Lexer
{
    public class Keyword : Token
    {
        public Keyword(string name) : base(name) { }

        public static bool IsKeyword(string text) => Keywords.Contains(text);

        private static readonly List<string> Keywords = new List<string>
        {
            "object",
            "end"
        };
    }
}
