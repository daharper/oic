namespace oic.Lexer
{
    /// <summary>
    /// Represents a token which is an identifier, i.e FirstName.
    /// </summary>
    public class Identifier : Token
    {
        public Identifier(string name, int lineNumber) : base(name, lineNumber) { }
    }
}
