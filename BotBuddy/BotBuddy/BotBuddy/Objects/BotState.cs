using System;
using System.Collections.Generic;
using System.Text;

namespace BotBuddy.Objects
{
    public enum BotState
    {
        happy,
        normal,
        sad,
        dirty,
        error,
        hungry
    }

    class BotStates
    {
        public static string GetBotString(BotState botState)
        {
            switch (botState)
            {
                case BotState.happy:
                    return "happy";
                case BotState.normal:
                    return "normal";
                case BotState.sad:
                    return "sad";
                case BotState.dirty:
                    return "dirty";
                case BotState.error:
                    return "error";
                case BotState.hungry:
                    return "hungry";
                default:
                    return "default";
            }
        }

        public static BotState GetBotState(string botString)
        {
            switch (botString)
            {
                case "happy":
                    return BotState.happy;
                case "normal":
                    return BotState.normal;
                case "sad":
                    return BotState.sad;
                case "dirty":
                    return BotState.dirty;
                case "error":
                    return BotState.error;
                case "hungry":
                    return BotState.hungry;
                default:
                    return BotState.happy;
            }
        }
    }
}
