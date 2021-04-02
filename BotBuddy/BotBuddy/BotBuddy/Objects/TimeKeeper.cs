using System;
using System.Collections.Generic;
using System.Text;

namespace BotBuddy.Objects
{
    public class TimeKeeper
    {

        /* STRING CONTAINING PROPERTY KEY */
        const string startTimeKey = "startTime";
        const string storedTimeKey = "storedTime";

        /* DateTime var used to store the start date value */
        public DateTime StartTime
        {
            get
            {
                /* CHECK IF DATE HAS BEEN SET */
                if (App.Current.Properties.ContainsKey(startTimeKey))
                {
                    return new DateTime((long)App.Current.Properties[startTimeKey]);
                }
                else
                {
                    return DateTime.Now;
                }
            }
            set
            {
                App.Current.Properties[startTimeKey] = value.Ticks;
            }
        }

        public DateTime StoredTime
        {
            get
            {
                /*  CHECK IF DATE VALUE HAS BEEN SET */
                if (App.Current.Properties.ContainsKey(storedTimeKey))
                {
                    return new DateTime((long)App.Current.Properties[storedTimeKey]);
                }
                else
                {
                    return DateTime.Now;
                }
            }
            set
            {
                App.Current.Properties[storedTimeKey] = value.Ticks;
            }
        }

        public TimeKeeper ()
        {

        }

        public double GetTimeElapsed()
        {
            return (StoredTime - StartTime).TotalSeconds;
        }

    }
}
