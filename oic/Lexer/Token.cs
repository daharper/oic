using oic.Utils;
using ScintillaNET;

namespace oic.Lexer
{
    public class Token
    {
        public Token(string text, int lineNumber)
        {
            Guard.Ensure.HasValue(text, nameof(text));
            Text = text;
            LineNumber = lineNumber;
        }

        public int LineNumber { get; }

        public string Text { get; }

        //public static implicit operator string(Token token) => token?.Text ?? string.Empty;

        //public static implicit operator Token(string text) => new Token(text);
    }
}
