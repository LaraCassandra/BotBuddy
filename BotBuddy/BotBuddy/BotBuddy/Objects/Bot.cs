using System;
using System.Collections.Generic;
using System.Text;

namespace BotBuddy.Objects
{
    public class Bot
    {

        /* STRING CONTAINING THE PROPERTY KEY */
        const string botStateKey = "botState";
        const string botXpKey = "botXp";
        const string botNameKey = "botName";


        public BotState CurrentBotState
        {
            get
            {

                if (App.Current.Properties.ContainsKey(botStateKey))
                {
                    return BotStates.GetBotState((string)App.Current.Properties[botStateKey]);
                }
                else
                {
                    return BotState.happy;
                }
            }
            set
            {
                App.Current.Properties[botStateKey] = BotStates.GetBotString(value);
            }
        }


        public int Xp
        {
            get
            {
                if (App.Current.Properties.ContainsKey(botXpKey))
                {
                    Console.WriteLine((int)App.Current.Properties[botXpKey]);
                    return (int)App.Current.Properties[botXpKey];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                App.Current.Properties[botXpKey] = value;
            }
        }

        public string BotName
        {
            get
            {
                if (App.Current.Properties.ContainsKey(botNameKey))
                {
                    return (string)App.Current.Properties[botNameKey];
                }
                else
                {
                    return "Bot Buddy";
                }
            }
            set
            {
                App.Current.Properties[botNameKey] = value;
            }
        }


        public Bot()
        {
        }


        public void giveLove()
        {
            Xp = Xp + 20;
        }

        public void cleanDirt()
        {
            Xp = Xp + 20;
        }

        public void foodCorrect()
        {
            Xp = Xp + 30;
        }

        public void foodWrong()
        {
            Xp = Xp - 50;
        }

        public void equationCorrect()
        {
            Xp = Xp + 50;
        }
        public void WinGame()
        {
            Xp = Xp + 100;
        }

    }
}
