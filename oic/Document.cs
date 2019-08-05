using System.Collections.Generic;

namespace oic
{
    public class Document
    {
        public const char Eol = '\n';

        public Document(string text)
        {
            Text = text.Trim();
            Lines.AddRange(text.Split(new char []{ Eol }));
        }

        public List<string> Lines { get; } = new List<string>();

        public string Line(int lineNumber) => Lines[lineNumber];

        public string Text { get; }
    }
}
