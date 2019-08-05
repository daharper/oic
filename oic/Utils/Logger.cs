using System;

namespace oic.Utils
{
    public static class Logger
    {
        public static Action<string> OnLog { get; set; }

        public static void WriteLn(string text) => OnLog?.Invoke(text);

        public static void NewLine(int count = 1)
        {
            if (OnLog == null) return;

            for (var i = 0; i < count; ++i)
                OnLog("");
        }
    }
}
