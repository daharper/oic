using System;
using System.Collections.Generic;
using oic.Lexer;
using oic.Utils;

namespace oic.Parser
{
    public class DfmProperty 
    {
        public DfmProperty(Token name, DfmValue value = null)
        {
            Guard.Ensure.NotNull(name, nameof(name));

            Name = name.Text;
            Add(value);
        }

        public void Add(DfmValue value)
        {
            if (!ReferenceEquals(null, value))
                _values.Add(value);
        }

        public string Name { get; }

        public string Value
        {
            get
            {
                Guard.Ensure.IsTrue(ValueCount == 1, "For multiple values, use the values property");
                return HasValues ? _values[0].Content : string.Empty;
            }
        }

        public bool HasValues => _values.Count > 0;

        public int ValueCount => _values.Count;

        public IEnumerable<DfmValue> Values => _values;

        private readonly List<DfmValue> _values = new List<DfmValue>();
    }
}
