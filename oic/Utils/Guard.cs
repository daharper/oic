﻿using System;
using System.Runtime.CompilerServices;

namespace oic.Utils
{
    public class Guard
    {
        public static readonly Guard Ensure = new Guard();

        public Guard NotNull(object obj, string objName = "", [CallerMemberName] string memberName = "")
        {
            if (ReferenceEquals(null, obj))
                Raise(new ArgumentNullException(objName, $"Required value missing error in {memberName}"));

            return this;
        }

        public Guard HasValue(string value, string name, [CallerMemberName] string memberName = "")
        {
            if (string.IsNullOrEmpty(value))
                Raise(new ArgumentNullException(name, $"Required value missing error in {memberName}"));

            return this;
        }

        public Guard IsTrue(bool condition, string message = "", [CallerMemberName] string memberName = "")
        {
            if (!condition)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    message = $"Failed condition in {memberName}" + Environment.NewLine + message;
                }

                Raise(new ArgumentException(message));
            }

            return this;
        }

        private static void Raise(Exception e)
        {
            Logger.NewLine();
            Logger.WriteLn("*****************************************************************");
            Logger.WriteLn($"Error: {e.Message}");
            Logger.WriteLn("*****************************************************************");
            Logger.NewLine();
            throw e;
        }
    }
}
