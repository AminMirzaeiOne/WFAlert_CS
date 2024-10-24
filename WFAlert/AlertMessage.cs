using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WFAlert
{
    public enum Actions
    {
        Wait,
        Start,
        Close
    }

    public enum Types
    {
        Success,
        Warning,
        Error,
        Info
    }

    public enum Themes
    {
        Light, Dark
    }

    public enum Styles
    {
        Fill, Border
    }

    public enum Sounds
    {
        ASound, BSound, CSound, DSound, ESound, FSound, GSound
    }


    public static class AlertMessage
    {
        

        public static WFAlert.Themes Theme { get; set; } = WFAlert.Themes.Light;
        public static WFAlert.Styles Style { get; set; } = WFAlert.Styles.Border;
        public static Font Font { get; set; } = new Font("Segoe UI", 10, FontStyle.Regular);

        public struct AlertSounds
        {
            private static System.IO.Stream soundLocation;
            private static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

            public static WFAlert.Sounds Success { get; set; } = Sounds.ASound;
            public static WFAlert.Sounds Error { get; set; } = Sounds.BSound;
            public static WFAlert.Sounds Info { get; set; } = Sounds.CSound;
            public static WFAlert.Sounds Warning { get; set; } = Sounds.DSound;

            private void StreamSound(WFAlert.Sounds sound)
            {
                switch (sound) 
                {
                    case Sounds.ASound:
                        soundLocation = Properties.Resources.ASound;
                        break;
                    case Sounds.BSound:
                        soundLocation = Properties.Resources.BSound;
                        break;
                    case Sounds.CSound:
                        soundLocation = Properties.Resources.CSound;
                        break;
                    case Sounds.DSound:
                        soundLocation = Properties.Resources.DSound;
                        break;
                    case Sounds.ESound:
                        soundLocation = Properties.Resources.ESound;
                        break;
                    case Sounds.FSound:
                        soundLocation = Properties.Resources.FSound;
                        break;
                    case Sounds.GSound:
                        soundLocation = Properties.Resources.GSound;
                        break;
                }
            }
        }

        public static void Show(string message, WFAlert.Types type, bool closebutton = true)
        {
            AlertWindow alertfrm = new AlertWindow(message, type, closebutton, AlertMessage.Theme, AlertMessage.Style, AlertMessage.Font);
        }


    }
}
