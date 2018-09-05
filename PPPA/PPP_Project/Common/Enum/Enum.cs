using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace PPP_Project.Common.Enum
{
    public enum ConnectionDAO
    {
        Server = 1,

        Client = 2,
    }

    public enum BranchCode
    {
        [Description("MW")]
        MainWareHouse = 2,
    }

    public enum RecordStatus
    {
        [Description("Save")]
        Save=2,
        [Description("Update")]
        Update=4,
        [Description("Sale")]
        Post=6,

        [Description("Pending")]
        Pending=8,

        [Description("Approved")]
        Approved=10,

        [Description("UnApproved")]
        UnApproved = 1,

        [Description("Confirmed")]
        Confirmed = 11,

    }
    public enum PostingStatus
    {
        Posting=1,

        Header=0,

        local=1,
    }

    public enum PassStatus
    {
        PendingPass=5,

        Reject = 10,

        Pass=15,
    }

    public enum UserType
    {
        [Description("Admin")]
        Admin = 8,

        [Description("Manager")]
        Manager = 7,

        [Description("Supervisor")]
        Supervisor = 6,

        [Description("TeamLeader")]
        TeamLeader = 5,

        [Description("Trainer")]
        TeamLeaderAssit = 4,
    }

    public enum Adjust
    {
        [Description("Minus")]
        Reduce=5,

        [Description("Add")]
        Add=10,
    }

    public enum Project
    {
        ABICA_Probes,
        ABITAMSUS_PROD_Probes,
        Regular,
        Important,
        Critical
    };
}