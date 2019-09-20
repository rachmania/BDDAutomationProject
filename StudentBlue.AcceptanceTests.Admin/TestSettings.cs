namespace StudentBlue.AcceptanceTests.Admin
{
    public static class TestSettings
    {
        //  Admin Super User
        public const string BaseUrl = "https://admin-qa.studentblue-abt.com";
        public const string SBAdminUsername = "rachman.walker+sbadmin@atlanticbt.com";
        public const string Password = "Password01!";
        //  Admin Read Only
        public const string SBAdminROUsername = "rachman.walker+adminreadonly@atlanticbt.com";
        public const string SBAdminROPassword = Password;
        //  StudentBlue Read Only
        public const string SBROUsername = "rachman.walker+readonly@atlanticbt.com";
        public const string SBROPassword = Password;
        //  StudentBlue Waiver Manager
        public const string SBWaiverMgrUsername = "rachman.walker+waivermanager@atlanticbt.com";
        public const string SBWaiverMgrPassword = Password;
        //  StudentBlue Waiver Processor
        public const string SBWaiverProcUsername = "rachman.walker+waiverprocessor@atlanticbt.com";
        public const string SBWaiverProcPassword = Password;
        //  University Admin - Winston-Salem State University
        public const string UniversityAdminUsername = "rachman.walker+wssuadmin@atlanticbt.com";
        public const string UniversityAdminPassword = Password;
        //  UNC System Admin - Winston-Salem State University
        public const string UNCAdminUsername = "rachman.walker+ncadmin@atlanticbt.com";
        public const string UNCAdminPassword = Password;
    }
}
