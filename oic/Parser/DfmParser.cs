using System;
using System.Collections.Generic;
using oic.Lexer;
using oic.Utils;

namespace oic.Parser
{
    /// <summary>
    /// Simple class to parse tokens and build a DfmObject.
    /// </summary>
    public static class DfmParser
    {
        public static DfmObject Execute(List<Token> tokens)
        {
            Logger.WriteLn($"DfmParser is executing...received: {tokens.Count} tokens");

            var objCount = 0;

            var stack = new Stack<DfmObject>();
            var queue = new Queue<Token>(tokens);

            DfmObject obj = null;
            DfmProperty property = null;

            while (queue.Count > 0)
            {
                var token = queue.Dequeue();

                if (token is Keyword)
                {
                    if (token.Text == "object")
                    {
                        var name = queue.Dequeue();
                        var type = queue.Dequeue();

                        Guard.Ensure
                            .IsTrue(name is Literal)
                            .IsTrue(type is Literal);

                        obj = new DfmObject(name, type);
                        ++objCount;

                        if (stack.Count > 0)
                            stack.Peek().Add(obj);

                        stack.Push(obj);
                    }

                    if (token.Text == "end")
                    {
                        if (stack.Count > 0)
                            obj = stack.Pop();
                    }

                    property = null;
                    continue;
                }

                if (token is Identifier)
                {
                    Guard.Ensure.NotNull(obj);

                    var op = queue.Dequeue();
                    var value = queue.Dequeue();

                    Guard.Ensure
                        .IsTrue(op is Operator)
                        .IsTrue(value is Literal);

                    property = new DfmProperty(token, new DfmValue(value));
                    obj?.Add(property);
                    continue;
                }

                if (token is Literal)
                {
                    Guard.Ensure
                        .NotNull(obj)
                        .NotNull(property);

                    property?.Add(new DfmValue(token));
                }
            }

            Guard.Ensure
                .IsTrue(stack.Count == 0)
                .NotNull(obj);

            Logger.WriteLn($"DfmParser is finished...{objCount} objects created." + Environment.NewLine);

            return obj;
        }
    }
}
