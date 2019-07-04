using System;

namespace oic.Utils
{
    public static class Logger
    {
        public static Action<string> OnLog { get; set; }

        public static void WriteLn(string text) => OnLog?.Invoke(text);
    }
}
