using System;

namespace notfiy.Helpers
{
    public static class Time
    {
        public static string CurrentTimeStamp()
        {
            return DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffffffZ");
        }

    }
}
