using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using oic.Utils;

namespace oic.Lexer
{
    /// <summary>
    /// Very simple class to read a Dfm text representation of an object and generate
    /// tokens. Currently there is only one operator. 
    /// </summary>
    public class Tokenizer
    {
        #region private

        private const string Ignored = ":[],";
        private const char OpeningQuote = '\'';
        private const char ClosingQuote = OpeningQuote;
        private const char Eol = '\n';
        private const char EqualsOperator = '=';

        private int _lineNumber = 1;

        #endregion

        public static List<Token> Execute(string text) => new Tokenizer().Run(text);

        public List<Token> Run(string text)
        {
            var tokens = new List<Token>();
            var sb = new StringBuilder();
            var inQuotes = false;
            
            Logger.WriteLn("Tokenizer executing on:" + Environment.NewLine);
            Logger.WriteLn(text + Environment.NewLine);

            for (var i = 0; i < text.Length; ++i)
            {
                var ch = text[i];

                if (inQuotes)
                {
                    sb.Append(ch);

                    if (ch == ClosingQuote)
                    {
                        inQuotes = false;
                        tokens.Add(new Literal(sb.ToString(), _lineNumber));
                        sb.Length = 0;
                    }
                    continue;
                }

                if (Ignored.Contains(ch)) continue;

                if (ch == OpeningQuote)
                {
                    Guard.Ensure.IsTrue(
                        sb.Length == 0, 
                        $"Line {_lineNumber}: expected empty buffer before new literal.");

                    sb.Append(ch);
                    inQuotes = true;
                    continue;
                }

                if (ch == Eol)
                {
                    ++_lineNumber;

                    if (sb.Length > 0)
                    {
                        tokens.Add(CreateToken(sb.ToString(), _lineNumber));
                        sb.Length = 0;
                    }
                    continue;
                }

                if (char.IsWhiteSpace(ch))
                {
                    if (sb.Length == 0) continue;

                    var value = sb.ToString();

                    if (Operator.IsOperator(value))
                    {
                        tokens.Add(new Operator(value, _lineNumber));
                        sb.Length = 0;
                        continue;
                    }

                    var (nextIndex, cn) = SkipWhitespace(i, text);

                    var token = cn == EqualsOperator
                        ? new Identifier(value, _lineNumber)
                        : CreateToken(value, _lineNumber);

                    tokens.Add(token);

                    i = nextIndex - 1;
                    sb.Length = 0;
                    continue;
                }

                sb.Append(ch);
            }

            if (sb.Length > 0)
                tokens.Add(CreateToken(sb.ToString(), _lineNumber));

            Logger.WriteLn($"Identified {tokens.Count} tokens:{Environment.NewLine}");

            foreach (var token in tokens)
                Logger.WriteLn($"* {token.Text} ({token.GetType().Name}){Environment.NewLine}");

            Logger.WriteLn($"Tokenizer has finished...{Environment.NewLine}");

            return tokens;
        }

        #region private methods

        private Token CreateToken(string text, int lineNumber)
        {
            if (Keyword.IsKeyword(text))
                return new Keyword(text, lineNumber);

            return new Literal(text, lineNumber);
        }

        private (int newIndex, char nextCh) SkipWhitespace(int currentIndex, string text)
        {
            for (var i = currentIndex + 1; i < text.Length; ++i)
            {
                var ch = text[i];
                if (!char.IsWhiteSpace(ch)) return (i, ch);
                if (ch == Eol) ++_lineNumber;
            }

            return (text.Length, ' ');
        }

        #endregion
    }
}
