using DataAccess.SEC;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;

namespace DataAccess.Users
{
    [Serializable]
    public partial class UserModel : StandardModel
    {
        public string USER_ID { get; set; }
        public string USER_FNAME_TH { get; set; }
        public string USER_LNAME_TH { get; set; }
        public string USER_FNAME_EN { get; set; }
        public string USER_LNAME_EN { get; set; }
        public string USER_NAME_EN { get; set; }
        public string USER_NAME_TH { get; set; }
        public Nullable<decimal> USG_ID { get; set; }
        public string SYS_GROUP_NAME { get; set; }
        public string COM_NAME_T { get; set; }
        public string COM_NAME_E { get; set; }
        public string USG_LEVEL { get; set; }
    }

    public class AppModel
    {
        public string COM_CODE { get; set; }
        public string USER_ID { get; set; }
        public int? USG_ID { get; set; }
        public string COM_NAME { get; set; }
        public string COM_NAME_E { get; set; }
        public string COM_NAME_T { get; set; }
    }

    public class NotificationModel
    {
        public string COM_CODE { get; set; }
        public string NO { get; set; }
        public string NTF_KEY { get; set; }
        public string USER_ID { get; set; }
        public string DETAIL { get; set; }
        public string FLAG { get; set; }
        public string ACTIVE { get; set; }
        public DateTime CRET_DATE { get; set; }
        public DateTime MNT_DATE { get; set; }
    }

    public class DashboardNewIssueModel
    {
        public string COM_CODE { get; set; }
        public string NO { get; set; }
        public string RESPONSE_BY { get; set; }
        public string ISSUE_BY { get; set; }
    }

    public class DashboardCountSummaryModel
    {
        public string ALL_ISSUE { get; set; }
        public string S_OPENING { get; set; }
        public string S_ON_PROCESS { get; set; }
        public string S_FOLLOW_UP { get; set; }
        public string S_GO_LIVE { get; set; }
        public string S_CLOSE { get; set; }
        public string RESPONSE_TIME_OUT { get; set; }
        public string RESOLUTION_TIME_OUT { get; set; }
        public string CLOSE_BEFOR_TARGET { get; set; }
        public string CLOSE_AFTER_TARGET { get; set; }
        public string DATENAME { get; set; }
        public string HIGH { get; set; }
        public string MEDIUM { get; set; }
        public string CRITICAL { get; set; }
        public string LOW { get; set; }
        public string APP_1 { get; set; }
        public string APP_2 { get; set; }
        public string APP_3 { get; set; }
        public string APP_4 { get; set; }
        public string APP_5 { get; set; }
    }

    //public class DashboardCountSummaryAllModel
    //{
    //    public string ALL_ISSUE { get; set; }
    //    public string S_OPENING { get; set; }
    //    public string S_ON_PROCESS { get; set; }
    //    public string S_FOLLOW_UP { get; set; }
    //    public string S_GO_LIVE { get; set; }
    //    public string S_CLOSE { get; set; }
    //    public string RESPONSE_TIME_OUT { get; set; }
    //    public string RESOLUTION_TIME_OUT { get; set; }
    //    public string CLOSE_BEFOR_TARGET { get; set; }
    //    public string CLOSE_AFTER_TARGET { get; set; }  
    //}

}
