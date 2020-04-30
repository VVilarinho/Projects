using System;

namespace BGT.Infrastructure.Persistence
{
    internal interface IDateTime
    {
        DateTime Now { get { return DateTime.Now; } }
    }
}