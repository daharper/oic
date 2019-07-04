using System.IO;

namespace oic.Utils
{
    public static class Config
    {
        public static readonly string StartupPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        public static readonly string StartupFolder = Path.GetDirectoryName(StartupPath);

        public static string GetPath(string relativePath) => Path.Combine(StartupFolder, relativePath);
    }
}
