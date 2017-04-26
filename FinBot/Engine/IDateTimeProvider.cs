using System;

namespace FinBot.Engine
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
        DateTime UtcNow { get; }
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.Now; } }
        public DateTime UtcNow { get { return DateTime.UtcNow; } }
    }
}