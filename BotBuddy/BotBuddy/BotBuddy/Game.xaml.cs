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
    public partial class Game : ContentPage
    {

        /* CREATE AN INSTANCE OF THE BOT OBJECT */
        private Bot bot = new Bot();

        public Game()
        {
            InitializeComponent();
        }


        /* DONE BUTTON */
        async void DoneButtonClicked(System.Object sender, System.EventArgs e)
        {
            BotPlay();
            await Navigation.PushModalAsync(new Home());
        }

        public void BotPlay()
        {
            // RANDOMISE A BLOCK
            Random rnd = new Random();
            int row = rnd.Next(1, 4);
            int column = rnd.Next(1, 4);
            string letter = "";

            
            
            if (row == 1)
            {
                letter = "A";
            }
            if (row == 2)
            {
                letter = "B";
            }
            if (row == 3)
            {
                letter = "C";
            }

            string block = letter + column.ToString();


            // POPULATE THE BLOCK
            if (block == "A1" && A1.Text == "")
            {
                A1.Text = "O";
            }
           
            else if (block == "A2" && A2.Text == "")
            {
                A2.Text = "O";
            }
            
            else if (block == "A3" && A3.Text == "")
            {
                A3.Text = "O";
            }

           else if (block == "B1" && B1.Text == "")
            {
                B1.Text = "O";
            }
            
          else  if (block == "B2" && B2.Text == "")
            {
                B2.Text = "O";
            }
           
           else if (block == "B3" && B3.Text == "")
            {
                B3.Text = "O";
            }
            
           else if (block == "C1" && C1.Text == "")
            {
                C1.Text = "O";
            }

           else if (block == "C2" && C2.Text == "")
            {
                C2.Text = "O";
            }

          else  if (block == "C3" && C3.Text == "")
            {
                C3.Text = "O";
            }

            else
            {
                BotPlay();
            }
            
        }

        /* CHECK FOR A WIN */
        public void CheckIfWin()
        {
            // HORIZONTAL WINS
            if((A1.Text == "X" && A2.Text == "X" && A3.Text == "X") || (A1.Text == "O" && A2.Text == "O" && A3.Text == "O"))
            {
                if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());


                }
            }
            if ((B1.Text == "X" && B2.Text == "X" && B3.Text == "X") || (B1.Text == "O" && B2.Text == "O" && B3.Text == "O"))
            {
                if (B1.Text == "O" && B2.Text == "O" && B3.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());


                }

            }
            if ((C1.Text == "X" && C2.Text == "X" && C3.Text == "X") || (C1.Text == "O" && C2.Text == "O" && C3.Text == "O"))
            {
                if (C1.Text == "O" && C2.Text == "O" && C3.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());


                }
            }

            // VERTICAL WINS
            if (A1.Text == "X" && B1.Text == "X" && C1.Text == "X" || (A1.Text == "O" && B1.Text == "O" && C1.Text == "O"))
            {
                if (A1.Text == "O" && B1.Text == "O" && C1.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());
                    

                }
               
            }
            if ((A2.Text == "X" && B2.Text == "X" && C2.Text == "X")|| (A2.Text == "O" && B2.Text == "O" && C2.Text == "O"))
            {
                if (A2.Text == "O" && B2.Text == "O" && C2.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());
                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());
                }

            }

            if ((A3.Text == "X" && B3.Text == "X" && C3.Text == "X") || (A3.Text == "O" && B3.Text == "O" && C3.Text == "O"))
            {
                if(A3.Text == "O" && B3.Text == "O" && C3.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());
                }
                

            }

            // DIAGONAL WINS
            if ((A1.Text == "X" && B2.Text == "X" && C3.Text == "X") || (A1.Text == "O" && B2.Text == "O" && C3.Text == "O"))
            {
                if (A1.Text == "O" && B2.Text == "O" && C3.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());
                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());
                }

            }

            if ((A3.Text == "X" && B2.Text == "X" && C1.Text == "X") || (A3.Text == "O" && B2.Text == "O" && C1.Text == "O"))
            {
                if (A3.Text == "O" && B2.Text == "O" && C1.Text == "O")
                {
                    DisplayAlert("alert", "Oh no! the bot won", "ok");
                    Navigation.PushModalAsync(new Home());

                }
                else
                {
                    DisplayAlert("alert", "Congrats the player won", "ok");
                    bot.WinGame();
                    Navigation.PushModalAsync(new Home());
                }


            }
            
            
        }

        /* USER CLICKS A BLOCK */
        private void A1_Clicked(object sender, EventArgs e)
        {
            
            if(A1.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                A1.Text = "X";
                BotPlay();
                CheckIfWin();
            }
           
            
        }

        private void A2_Clicked(object sender, EventArgs e)
        {

            if (A2.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                A2.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void A3_Clicked(object sender, EventArgs e)
        {
            if (A3.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                A3.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void B1_Clicked(object sender, EventArgs e)
        {
            if (B1.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                B1.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void B2_Clicked(object sender, EventArgs e)
        {
            if (B2.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                B2.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void B3_Clicked(object sender, EventArgs e)
        {
            if (B3.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                B3.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void C1_Clicked(object sender, EventArgs e)
        {
            if (C1.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                C1.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }

        private void C2_Clicked(object sender, EventArgs e)
        {
            if (C2.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                C2.Text = "X";
                BotPlay();
                CheckIfWin();
            }
          
        }

        private void C3_Clicked(object sender, EventArgs e)
        {
            if (C3.Text != "")
            {
                DisplayAlert("alert", "You cant click here!", "ok");
            }
            else
            {
                C3.Text = "X";
                BotPlay();
                CheckIfWin();
            }
        }
    }
}