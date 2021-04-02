using System;
using System.Collections.Generic;
using System.Text;

namespace BotBuddy.Objects
{
    class Levels
    {
        public static int GetLevelFromXp(int xp)
        {
            if (xp == 0)
            {
                return 0;
            }
            else if (xp < 200)
            {
                return 1;
            } 
            else if (xp >= 200 && xp <300)
            {
                return 2;
            }
            else if (xp >= 300 && xp < 400)
            {
                return 3;
            }
            else if (xp >= 400 & xp < 500)
            {
                return 4;
            }
            else if (xp >= 500 & xp < 600)
            {
                return 5;
            }
            else if (xp >= 600 & xp < 700)
            {
                return 6;
            }

            else if (xp >= 700 & xp < 800)
            {
                return 7;
            }

            else if (xp >= 800 & xp < 900)
            {
                return 8;
            }

            else if (xp >= 900 & xp < 1000)
            {
                return 9;
            }
            else if (xp >= 1000 & xp < 2000)
            {
                return 10;
            }
            else
            {
                return 10;
            }
        }
    }
}
