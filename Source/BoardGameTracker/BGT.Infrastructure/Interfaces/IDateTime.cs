using System;

namespace BGT.Infrastructure.Persistence
{
    public interface IDateTime
    {
        DateTime Now { get { return DateTime.Now; } }
    }
}