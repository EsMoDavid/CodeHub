using System;

namespace CodeHub.Core
{
    public static class Secrets
    {
        public static string GithubOAuthId
        {
            //get { throw new InvalidOperationException("You must get your own Key"); }
            get { return "8a816335cc15859de78a"; }
        }

        public static string GithubOAuthSecret
        {
            //get { throw new InvalidOperationException("You must get your own Secret"); }
            get { return "3c2ddb8bb231cf118dfa5766fb617ccf83fb7ac0"; }
        }

        public static string ErrorReportingKey
        {
            get { throw new InvalidOperationException("You must have a valid error reporting key"); }
        }
    }
}