using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BotBuddy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BeginButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NameBot());
        }
    }
}
