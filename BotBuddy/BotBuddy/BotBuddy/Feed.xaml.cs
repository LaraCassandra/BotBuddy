using BotBuddy.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotBuddy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feed : ContentPage
    {

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();

        public Feed()
        {
            InitializeComponent();
        }

        /* WRONG FOOD CLICKED */
        void burgerButtonClicked(System.Object sender, System.EventArgs e)
        {
            bot.foodWrong();
            burgerButton.Source = "";
        }

        void pizzaButtonClicked(System.Object sender, System.EventArgs e)
        {
            bot.foodWrong();
            pizzaButton.Source = "";
        }

        /* CORRECT FOOD CLICKED */
        void fuelButtonClicked(System.Object sender, System.EventArgs e)
        {
            bot.foodCorrect();
            fuelButton.Source = "";
        }

        void gearButtonClicked(System.Object sender, System.EventArgs e)
        {
            bot.foodCorrect();
            gearButton.Source = "";
        }

        /* DONE BUTTON */
        async void DoneButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Home());
        }

    }
}