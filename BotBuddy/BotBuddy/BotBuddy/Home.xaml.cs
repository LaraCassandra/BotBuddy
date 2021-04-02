using BotBuddy.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotBuddy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();

        public Home ()
        {
            InitializeComponent();

            updateUI();
            StartTimer();
            ResetTimer();

        }

        /* UPDATE THE UI */
        void updateUI()
        {
            int botXp = bot.Xp;

            if (botXp <= 0)
            {
                botNameLabel.Text = bot.BotName;
                levelLabel.Text = "Your bot is off";
                xpLabel.Text = "Tap the heart to turn on";
               
            }
            else
            {
                botNameLabel.Text = bot.BotName;
                levelLabel.Text = "Level " + Levels.GetLevelFromXp(botXp).ToString();
                xpLabel.Text = botXp.ToString();
            }
            
            //botNameLabel.Text = bot.BotName2;

            Device.BeginInvokeOnMainThread(async () =>
            {
                botImage.Source = "bot_" + bot.CurrentBotState;


                if (bot.CurrentBotState == BotState.sad)
                {
                    BotSad();
                }           
//                else if (bot.CurrentBotState == BotState.dirty)
//                {
//                    await DisplayAlert("Dirty", "You need to clean your bot", "Okay");
//                }
//                else if (bot.CurrentBotState == BotState.error)
//                {
//                    await DisplayAlert("Error", "You need to repair your bot", "Okay");
//                }
//                else if (bot.CurrentBotState == BotState.hungry)
//                {
//                    await DisplayAlert("Hungry", "Your bot is hungry", "Feed");
//                }

            });

        }

        /* LOVE BUTTON CLICKED */
        void loveButtonClicked(System.Object sender, System.EventArgs e)
        {
            ResetTimer();
            bot.giveLove();
            updateUI();
        }

        /* CLEAN BUTTON CLICKED */
        async void cleanButtonClicked(System.Object sender, System.EventArgs e)
        {
            
            ResetTimer();
            ResetCleanTimer();
            await Navigation.PushModalAsync(new Clean());
            
        }

        /* FEED BUTTON CLICKED */
        async void feedButtonClicked(System.Object sender, System.EventArgs e)
        {
            ResetTimer();
            ResetFeedTimer();
            await Navigation.PushModalAsync(new Feed());
        }

        /* REPAIR BUTTON CLICKED */
        async void repairButtonClicked(System.Object sender, System.EventArgs e)
        {
            ResetTimer();
            ResetRepairTimer();
            await Navigation.PushModalAsync(new Repair());
        }

        /* GAME BUTTON CLICKED */
        async void gameButtonClicked(System.Object sender, System.EventArgs e)
        {
            ResetTimer();
            await Navigation.PushModalAsync(new Game());
        }



        /* RESET BOT AFTER TIME */
        private async void BotSad()
        {
            await DisplayAlert("Oh No!", "Your Bot has Malfunctioned", "New Bot");

            bot.Xp = 0;
            bot.CurrentBotState = BotState.happy;
            ResetTimer();

            updateUI();
        }



        /* CREATE AN INSTANCE OF TIMEKEEPER OBJECTS */
        private TimeKeeper timeKeeper = new TimeKeeper();
        private CleanTimeKeeper cleanTimeKeeper = new CleanTimeKeeper();
        private RepairTimeKeeper repairTimeKeeper = new RepairTimeKeeper();
        private FeedTimeKeeper feedTimeKeeper = new FeedTimeKeeper();


        /* CREATE A TIMER */
        private static Timer timer;

        /* TIMER EVENTS */
        private void StartTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateTimedData;
            timer.Start();
        }


        /* CLEAN TIMER EVENTS */
        private void StartCleanTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateCleanTimedData;
            timer.Start();
        }

        /* REPAIR TIMER EVENTS */
        private void StartRepairTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateRepairTimedData;
            timer.Start();
        }


        /* REPAIR TIMER EVENTS */
        private void StartFeedTimer()
        {
            timer = new Timer();

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += UpdateFeedTimedData;
            timer.Start();
        }


        /* RESET TIMER */
        private void ResetTimer()
        {
            timeKeeper.StartTime = DateTime.Now;
            StartTimer();
        }
        
        /* RESET CLEAN TIMER */
        private void ResetCleanTimer()
        {
            cleanTimeKeeper.StartTime = DateTime.Now;
            StartCleanTimer();
        }

        /* RESET REPAIR TIMER */
        private void ResetRepairTimer()
        {
            repairTimeKeeper.StartTime = DateTime.Now;
            StartRepairTimer();
        }

        /* RESET FEED TIMER */
        private void ResetFeedTimer()
        {
            repairTimeKeeper.StartTime = DateTime.Now;
            StartFeedTimer();
        }



        /* TIMER TO SET BOT STATE */
        private void UpdateTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeElapsed = e.SignalTime - timeKeeper.StartTime;

            BotState newBotState = bot.CurrentBotState;

            if (timeElapsed.TotalSeconds < 100)
            {
                newBotState = BotState.happy;
            }
            else if (timeElapsed.TotalSeconds < 200)
            {
                newBotState = BotState.normal;
            }
            else if (timeElapsed.TotalSeconds >= 300)
            {
                newBotState = BotState.sad;
            }

            if (newBotState != bot.CurrentBotState)
            {
                bot.CurrentBotState = newBotState;
                updateUI();
            }

        }

        /* CLEAN TIMER TO SET BOT STATE */
        private void UpdateCleanTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeCleanElapsed = e.SignalTime - cleanTimeKeeper.StartTime;

            BotState newBotState = bot.CurrentBotState;

            if (timeCleanElapsed.TotalSeconds < 50)
            {
                newBotState = BotState.happy;
            }
            else if (timeCleanElapsed.TotalSeconds < 100)
            {
                newBotState = BotState.normal;
            }
            else if (timeCleanElapsed.TotalSeconds >= 150)
            {
                newBotState = BotState.dirty;
            }

            if (newBotState != bot.CurrentBotState)
            {
                bot.CurrentBotState = newBotState;
                updateUI();
            }

        }


        /* REAPAIR TIMER TO SET BOT STATE */
        private void UpdateRepairTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeRepairElapsed = e.SignalTime - repairTimeKeeper.StartTime;

            BotState newBotState = bot.CurrentBotState;

            if (timeRepairElapsed.TotalSeconds < 80)
            {
                newBotState = BotState.happy;
            }
            else if (timeRepairElapsed.TotalSeconds < 120)
            {
                newBotState = BotState.normal;
            }
            else if (timeRepairElapsed.TotalSeconds >= 180)
            {
                newBotState = BotState.error;
            }

            if (newBotState != bot.CurrentBotState)
            {
                bot.CurrentBotState = newBotState;
                updateUI();
            }

        }


        /* FEED TIMER TO SET BOT STATE */
        private void UpdateFeedTimedData(object sender, ElapsedEventArgs e)
        {
            TimeSpan timeFeedElapsed = e.SignalTime - feedTimeKeeper.StartTime;

            BotState newBotState = bot.CurrentBotState;

            if (timeFeedElapsed.TotalSeconds < 180)
            {
                newBotState = BotState.happy;
            }
            else if (timeFeedElapsed.TotalSeconds < 220)
            {
                newBotState = BotState.normal;
            }
            else if (timeFeedElapsed.TotalSeconds >= 280)
            {
                newBotState = BotState.hungry;
            }

            if (newBotState != bot.CurrentBotState)
            {
                bot.CurrentBotState = newBotState;
                updateUI();
            }

        }


    }
}