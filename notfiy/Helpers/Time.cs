using System;

namespace notfiy.Helpers
{
    public static class Time
    {
        public static DateTime CurrentTimeStamp()
        {
            return DateTime.UtcNow;
        }
    }
}
