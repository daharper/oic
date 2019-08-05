using System.Collections.Generic;
using oic.Lexer;
using oic.Utils;

namespace oic.Parser
{
    public class DfmProperty 
    {
        //public DfmProperty(string name, DfmValue value = null)
        //{
        //    Guard.Ensure.NotNull(name, nameof(name));

        //    Name = name;
        //    Add(value);
        //}

        public DfmProperty(Token name, DfmValue value = null)
        {
            Guard.Ensure.NotNull(name, nameof(name));

            Name = name.Text;
            LineNumber = name.LineNumber;
            Add(value);
        }

        public void Add(DfmValue value)
        {
            if (!ReferenceEquals(null, value))
                _values.Add(value);
        }

        public int LineNumber { get; } = 0;

        public string Name { get; }

        public string Value
        {
            get
            {
                Guard.Ensure.IsTrue(
                    ValueCount == 1, 
                    $"Line {LineNumber}: For multiple values, use the values property");

                return HasValues ? _values[0].Content : string.Empty;
            }
        }

        public bool HasValues => _values.Count > 0;

        public int ValueCount => _values.Count;

        public IEnumerable<DfmValue> Values => _values;

        private readonly List<DfmValue> _values = new List<DfmValue>();
    }
}
