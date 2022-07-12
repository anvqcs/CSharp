using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using AxWMPLib;

namespace FinalCSharp
{
    class DFSoundPlayer
    {
        public static SoundPlayer media_click = new SoundPlayer(global::FinalCSharp.Properties.Resources.hit);
        //public static SoundPlayer media_help = new SoundPlayer(global::FinalCSharp.Properties.Resources.Help1);
        public static SoundPlayer media_pikachu = new SoundPlayer(global::FinalCSharp.Properties.Resources.eat);
        public static SoundPlayer media_nope = new SoundPlayer(global::FinalCSharp.Properties.Resources.wrong);
        public static SoundPlayer media_theme = new SoundPlayer(global::FinalCSharp.Properties.Resources.theme1);
        public static SoundPlayer media_win = new SoundPlayer(global::FinalCSharp.Properties.Resources.winner);
        public static SoundPlayer media_lose = new SoundPlayer(global::FinalCSharp.Properties.Resources.lose);

        public static void BackgroundSound(AxWindowsMediaPlayer BgMusic)
        {
            //BgMusic.URL = "theme1.mp3";
            //BgMusic.Ctlcontrols.play();
        }
    }
}
