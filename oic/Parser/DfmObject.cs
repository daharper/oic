using System.Collections.Generic;
using oic.Lexer;
using oic.Utils;

namespace oic.Parser
{
    public class DfmObject 
    {
        public DfmObject(Token name, Token type)
        {
            Guard.Ensure
                .NotNull(name, nameof(name))
                .NotNull(type, nameof(type));

            Name = name.Text;
            Type = type.Text;
        }

        public string Name { get; }

        public string Type { get; } 

        public List<DfmProperty> Properties { get; } = new List<DfmProperty>();

        public List<DfmObject> Objects { get; } = new List<DfmObject>();

        public bool HasProperties => Properties.Count > 0;

        public bool HasObjects => Objects.Count > 0;

        public int PropertyCount => Properties.Count;

        public int ObjectCount => Objects.Count;

        public void Add(DfmProperty property)
        {
            if (!ReferenceEquals(null, property))
                Properties.Add(property);
        }

        public void Add(DfmObject obj)
        {
            if (!ReferenceEquals(null, obj)) 
                Objects.Add(obj);
        }
    }
}
