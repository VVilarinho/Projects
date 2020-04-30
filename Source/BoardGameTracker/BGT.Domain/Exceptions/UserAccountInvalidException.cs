using System;

namespace BGT.Domain.Exceptions
{
    public class UserAccountInvalidException : Exception
    {
        public UserAccountInvalidException(string adAccount, Exception ex)
            : base($"User Account \"{adAccount}\" is invalid.", ex)
        {
        }
    }
}