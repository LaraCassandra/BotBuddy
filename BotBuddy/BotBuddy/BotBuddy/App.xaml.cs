using BotBuddy.Objects;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotBuddy
{
    public partial class App : Application
    {

        /* CREATE AN INSTANCE OF TIMEKEEPER OBJECT */
        private TimeKeeper timeKeeper = new TimeKeeper();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Console.WriteLine("OnStart");

            /* GET THE CURRENT SYSTEM TIME FROM TIMEKEEPER OBJECT */
            Console.WriteLine(timeKeeper.StoredTime);
            Console.WriteLine(timeKeeper.GetTimeElapsed());
        }

        protected override void OnSleep()
        {
            Console.WriteLine("OnSleep");

            /* SAVE THE CURRENT SYSTEM TIME TO THE TIMEKEEPER OBJECT*/
            timeKeeper.StoredTime = DateTime.Now;
        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");

            /* GET THE CURRENT SYSTEM TIME FROM TIMEKEEPER OBJECT*/
            Console.WriteLine(timeKeeper.StoredTime);
            Console.WriteLine(timeKeeper.GetTimeElapsed());
        }
    }
}
