using System;

namespace Shell.NET
{
    internal static class EnvironmentUtils
    {
        internal static bool IsUnix()
        {
            PlatformID pId = Environment.OSVersion.Platform;

            return (pId == PlatformID.Unix || pId == PlatformID.MacOSX || (int)pId == 128);
        }
    }
}
