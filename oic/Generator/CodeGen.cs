using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using oic.Parser;
using oic.Utils;

namespace oic.Generator
{
    /// <summary>
    /// Performs very basic code generation, converting a DfmObject in Delphi code.
    /// </summary>
    public class CodeGen
    {
        #region private

        private DfmObject _dfmObject;

        private string _template;

        private readonly List<string> _loc = new List<string>();

        private int _objCount;

        #endregion

        /// <summary>
        /// Generates Delphi code for the specified Dfm.
        /// </summary>
        /// <param name="dfmObject">An object representing a Dfm definition</param>
        /// <returns></returns>
        public static string Execute(DfmObject dfmObject) => new CodeGen().Run(dfmObject);

        #region private methods

        private string Run(DfmObject obj)
        {
            Logger.WriteLn("CodeGen executing...");

            Guard.Ensure.NotNull(obj, nameof(obj), "DfmObject has not been initialized");

            _dfmObject = obj;
            _template = File.ReadAllText(Config.GetPath(@"Generator\Template.txt"));
            _objCount = 0;

            Logger.WriteLn("- template and function signature");
            InitFunctionSignature();

            Logger.WriteLn("- vars section");
            InitVarSection();

            Logger.WriteLn("- object creation");
            InitObjects();

            Logger.WriteLn("- object assignments");
            InitAssignments();

            Logger.WriteLn("CodeGen is finished...");

            return _template;
        }

        // initial template configuration

        private void InitFunctionSignature()
        {
            _template = _template
                .Replace("@name", _dfmObject.Type.Substring(1))
                .Replace("@type", _dfmObject.Type)
                .Replace("@result", _dfmObject.Name);
        }

        // generate the var section

        private void InitVarSection()
        {
            var sb = new StringBuilder();
            AddVarEntry(sb, _dfmObject);

            _template = _template
                .Replace("@vars", sb.ToString().TrimEnd());
        }

        private void AddVarEntry(StringBuilder sb, DfmObject parent)
        {
            sb.AppendLine($"\t{parent.Name}: {parent.Type};");

            foreach (var child in parent.Objects)
                AddVarEntry(sb, child);
        }

        // generate objects and properties

        private void InitObjects()
        {
            var sb = new StringBuilder();
            AddObject(sb, _dfmObject);

            _template = _template
                .Replace("@objects", sb.ToString().TrimEnd() + Environment.NewLine);
        }

        private void AddObject(StringBuilder sb, DfmObject parent)
        {
            ++_objCount;

            var indent = new string('\t', _objCount);

            Logger.WriteLn($"{indent}Creating object ({_objCount}): {parent.Name}");

            sb.AppendLine($"\t{parent.Name} := {parent.Type}.Create(nil);");

            foreach (var property in parent.Properties)
            {
                Logger.WriteLn($"{indent}\tCreating property: {property.Name}");

                var name = PropertyNameAdapter.Adapt(parent, property);

                if (string.IsNullOrEmpty(name))
                {
                    sb.AppendLine("\t// ignored property");
                    sb.AppendLine($"\t// {parent.Name}.{property.Name} := {property.Value};");
                }
                else if (IsEventHandler(property.Name))
                {
                    sb.AppendLine($"\t// {parent.Name}.{name} := {property.Value};");
                }
                else
                {
                    var value = PropertyValueAdapter.Adapt(property.Name, property);
                    sb.AppendLine($"\t{parent.Name}.{name} := {value};");
                }
            }

            sb.AppendLine();

            foreach (var child in parent.Objects)
                AddObject(sb, child);
        }

        // assign child objects to their parents

        private void InitAssignments()
        {
            if (!_dfmObject.HasObjects) return;

            var stack = new Stack<string>();
            AddAssignment(stack, _dfmObject);

            var sb = new StringBuilder();

            while (stack.Count > 0)
                sb.AppendLine(stack.Pop());

            _template = _template.Replace("@assignments", sb.ToString().TrimEnd());
        }

        private void AddAssignment(Stack<string> stack, DfmObject parent)
        {
            foreach (var child in parent.Objects)
                stack.Push($"\t{parent.Name}.AddObject({child.Name});");

            foreach (var child in parent.Objects)
                AddAssignment(stack, child);
        }

        // determine if an property name is an event handler

        private static bool IsEventHandler(string name) => name.StartsWith("On");

        #endregion
    }
}
