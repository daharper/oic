using System.Collections.Generic;

namespace oic.Lexer
{
    /// <summary>
    /// Represents a token which is a Keyword.
    /// </summary>
    public class Keyword : Token
    {
        public Keyword(string name, int lineNumber) : base(name, lineNumber) { }

        public string Name => base.Text;
        
        public static bool IsKeyword(string text) => Keywords.Contains(text);

        public bool IntroducesAnObject => ObjectIdentifiers.Contains(Name);

        public bool IsEnd => Name == "end";

        private static readonly List<string> ObjectIdentifiers = new List<string>
        {
            "object",
            "inline",
            "inherited"
        };

        private static readonly List<string> Keywords = new List<string>
        {
            "object",
            "end",

            // what do these two do? Can we replace them with "object"
            "inline",
            "inherited"
        };
    }
}
