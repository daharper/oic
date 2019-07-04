using System.Text;
using oic.Parser;
using oic.Utils;

namespace oic.Generator
{
    /// <summary>
    /// Dfm values don't always map one to one to FMX, some need to be coerced.
    /// This will need to be build out as more values are handled.
    /// </summary>
    public static class PropertyNameAdapter
    {
        public static string Adapt(DfmObject obj, DfmProperty property)
        {
            var name = property.Name.ToLowerInvariant();

            if (name == "viewport.width") return "Width";

            if (name == "viewport.height") return "Height";

            if (name == "designermasterstyle") return string.Empty;

            return property.Name;
        }
    }
}
