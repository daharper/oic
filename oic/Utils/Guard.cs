using System;
using System.Runtime.CompilerServices;

namespace oic.Utils
{
    public class Guard
    {
        public static readonly Guard Ensure = new Guard();

        public Guard NotNull(object obj, string objName = "", [CallerMemberName] string memberName = "")
        {
            if (ReferenceEquals(null, obj)) 
                throw new ArgumentNullException(objName, $"Required value missing error in {memberName}");

            return this;
        }

        public Guard HasValue(string value, string name, [CallerMemberName] string memberName = "")
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException(name, $"Required value missing error in {memberName}");

            return this;
        }

        public Guard IsTrue(bool condition, string message = "", [CallerMemberName] string memberName = "")
        {
            if (!condition)
                throw new ArgumentException($"Failed condition in {memberName}");

            return this;
        }

    }
}
