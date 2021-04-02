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
    public partial class Repair : ContentPage
    {

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();

        /* CREATE GLOBAL ANSWER VARIABLE */
        int answer = 0;

        public Repair()
        {
            InitializeComponent();
            updateUI();
            
        }
        
       public void updateUI()
        {

            /* MAKE EQUATION */
            Random rnd = new Random();
            int num1 = rnd.Next(100);
            int num2 = rnd.Next(100);

            equation.Text = num1 + "+" + num2;

            answer = num1 + num2;

        }

        async void DoneButtonClicked(System.Object sender, System.EventArgs e)
        {
            if (userAnswer.Text == answer.ToString())
            {
                bot.equationCorrect();
                await DisplayAlert("Good Job!", "You got 50xp points!", "Nice!");
                await Navigation.PushModalAsync(new Home());
            }
            else
            {
                await DisplayAlert("Oops!", "That was wrong, you don't get any points", "Okay");
                await Navigation.PushModalAsync(new Home());
            }
        }


    }
}