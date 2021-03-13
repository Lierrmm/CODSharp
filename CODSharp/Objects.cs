using System.ComponentModel;

namespace CODSharp
{
    public class baseResponse
    {
        public string status { get; set; }
    }

    public class Stats : baseResponse
    {
        public dynamic data { get; set; }
    }

    public enum platforms
    {
        [Description("Xbox")] xbl,
        [Description("Playstation")] psn,
        [Description("BattleNET")] battle,
        [Description("Numerical Activision ID")] uno,
        [Description("Activision ID")] acti,
        all
    }

    public enum friendActions
    {
        invite,
        uninvite,
        remove,
        block,
        unblock
    }

    public enum friendVisibility
    {
        all,
        none,
        friends,
        friends_tourneys
    }
}
