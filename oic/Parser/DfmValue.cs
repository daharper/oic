using oic.Lexer;
using oic.Utils;

namespace oic.Parser
{
    public class DfmValue
    {
        public DfmValue(Token token)
        {
            Guard.Ensure.NotNull(token, nameof(token));
            Content = token.Text;
        }

        public static implicit operator string(DfmValue value) => value?.Content ?? string.Empty;

        public static implicit operator DfmValue(string value) => new DfmValue(value);

        public string Content { get; }
    }
}
