using oic.Utils;

namespace oic.Lexer
{
    public class Token
    {
        public Token(string text)
        {
            Guard.Ensure.HasValue(text, nameof(text));
            Text = text;
        }

        public string Text { get; }

        public static implicit operator string(Token token) => token?.Text ?? string.Empty;

        public static implicit operator Token(string text) => new Token(text);
    }
}
