using BotBuddy.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BotBuddy


{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NameBot : ContentPage
    {

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();
        
        public NameBot()
        {
            InitializeComponent();
        }


        async void SaveBotClicked(System.Object sender, System.EventArgs e)
        {

            bot.BotName = MainEntry.Text;
          
            await Navigation.PushModalAsync(new Home());
        }
    }
}