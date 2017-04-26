using System;
using FinBot.Engine;

namespace FinBot.Tests.Engine
{
    public class MockDateTimeProvider : IDateTimeProvider
    {
        private readonly DateTime _dateTime;

        public MockDateTimeProvider(DateTime dateTime)
        {
            _dateTime = dateTime;
        }

        public DateTime Now { get { return _dateTime;} }
        public DateTime UtcNow { get { return _dateTime; } }
    }
}