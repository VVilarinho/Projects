using System;

namespace BGT.Domain.Exceptions
{
    public class InvalidSubmissionEntryException : Exception
    {
        public InvalidSubmissionEntryException(string adAccount, Exception ex)
            : base($"User Account \"{adAccount}\" is invalid.", ex)
        {
        }
    }
}