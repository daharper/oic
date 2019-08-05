using System.Text;
using oic.Parser;
using oic.Utils;

namespace oic.Generator
{
    /// <summary>
    /// Dfm values don't always map one to one to FMX, some need to be coerced.
    /// This will need to be build out as more values are handled.
    /// </summary>
    public static class PropertyValueAdapter
    {
        public static string Adapt(string name, DfmProperty property)
        {
            name = name.ToLowerInvariant();

            if (name.EndsWith("color"))
                return Color(property.Value);

            if (name.EndsWith("align"))
                return Alignment(property);

            if (name.EndsWith("anchors"))
                return Anchors(property);

            if (name.EndsWith("dragmode"))
                return DragMode(property.Value);

            if (name.EndsWith("devices"))
                return Devices(property);

            if (name.EndsWith("styledsettings"))
                return StyledSettings(property);

            return property.Value;
        }

        #region private methods

        private static string Alignment(DfmProperty property)
        {
            Guard.Ensure.IsTrue(property.HasValues, "Alignment property has no value error.");
            return $"TAlignLayout.{property.Value}";
        }

        private static string Devices(DfmProperty property)
        {
            Guard.Ensure.IsTrue(property.HasValues, "Device property has no value error.");
            return $"TDeviceKinds.{property.Value}";
        }

        private static string Anchors(DfmProperty property)
        {
            Guard.Ensure.IsTrue(property.HasValues, "Anchors property has no value error.");

            var sb = new StringBuilder();
            sb.Append("[");

            foreach (var value in property.Values)
                sb.Append($"TAnchorKind.{value.Content}, ");

            sb.Length -= 2;
            sb.Append("]");

            return sb.ToString();
        }

        private static string StyledSettings(DfmProperty property)
        {
            Guard.Ensure.IsTrue(property.HasValues, "StyledSettings property has no value error.");

            var sb = new StringBuilder();
            sb.Append("[");

            foreach (var value in property.Values)
                sb.Append($"TStyledSetting.{value.Content}, ");

            sb.Length -= 2;
            sb.Append("]");

            return sb.ToString();
        }

        private static string Color(string value)
        {
            if (value.StartsWith("x")) return "$" + value.Substring(1);

            if (value.StartsWith("cla")) return "TAlphaColors." + value.Substring(3);

            return value;
        }

        private static string DragMode(string value) => "TDragMode." + value;

        #endregion
    }
}
