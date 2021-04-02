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
    public partial class Clean : ContentPage
    {

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();
        public Clean()
        {
            InitializeComponent();
        }

        /* DIRT BUTTON 1 */
        void dirtButton1Clicked(System.Object sender, System.EventArgs e)
        {
            bot.cleanDirt();
            dirtButton1.Source = "";
        }

        /* DIRT BUTTON 2 */
        void dirtButton2Clicked(System.Object sender, System.EventArgs e)
        {
            bot.cleanDirt();
            dirtButton2.Source = "";
        }

        /* DIRT BUTTON 4 */

        void dirtButton3Clicked(System.Object sender, System.EventArgs e)
        {
            bot.cleanDirt();
            dirtButton3.Source = "";
        }

        /* DONE BUTTON */
        async void DoneButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Home());
        }

    }
}