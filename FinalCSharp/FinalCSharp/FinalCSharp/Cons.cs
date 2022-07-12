using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FinalCSharp
{
    class Cons
    {
        public static bool END = false;
        public static Color BACK_COLOR = Color.Bisque; 
        public static bool SOUND = true;
        public static string PLAYER_NAME = "";
        public static int HINT = 2;
        public static string IMAGE = "Pokemon";
        public static int SCORE = 0;
        public static bool NEWGAME = true;
        public static bool GAME_OVER = false;
        public static int WIDTH;
        public static int HEIGHT;
        public static int CHESS_WIDTH = 40;
        public static int CHESS_HEIGHT = 50;
        public static int NUM_OF_TYPE = 10;
        public static int LEVEL = 1;
        public static int[,] ARR_LEVEL =
        {
            {0, 0, 0, 0},
            {1, 10, 6, 12},
            {2, 10, 6, 14},
            {3, 11, 6, 16},
            {4, 11, 6, 18},
            {5, 12, 7, 20},
            {6, 12, 7, 22},
            {7, 13, 8, 24},
            {8, 13, 8, 26},
            {9, 14, 9, 28},
            {10, 14, 9, 30},
            {11, 15, 10, 31},
            {12, 15, 10, 33},
            {13, 16, 11, 35},
            {14, 16, 11, 36}
        };
        public static bool WIN;
    }
}
