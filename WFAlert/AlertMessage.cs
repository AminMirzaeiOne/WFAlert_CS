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
        None, ASound, BSound, CSound, DSound, ESound, FSound, GSound
    }


    public static class AlertMessage
    {


        public static WFAlert.Themes Theme { get; set; } = WFAlert.Themes.Light;
        public static WFAlert.Styles Style { get; set; } = WFAlert.Styles.Border;
        public static Font Font { get; set; } = new Font("Segoe UI", 10, FontStyle.Regular);
        public static bool Animation { get; set; } = true;

        public struct AlertSounds
        {
            private static System.IO.Stream soundLocation;
            private static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();

            public static WFAlert.Sounds Success { get; set; } = Sounds.DSound;
            public static WFAlert.Sounds Error { get; set; } = Sounds.DSound;
            public static WFAlert.Sounds Info { get; set; } = Sounds.None;
            public static WFAlert.Sounds Warning { get; set; } = Sounds.DSound;

            internal static void StreamSound(WFAlert.Sounds sound)
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

            public struct AlertAnimation
            {
                public static WFAnimations.AnimationType Success { get; set; } = WFAnimations.AnimationType.Scale;
                public static WFAnimations.AnimationType Error { get; set; } = WFAnimations.AnimationType.Scale;
                public static WFAnimations.AnimationType Info { get; set; } = WFAnimations.AnimationType.Scale;
                public static WFAnimations.AnimationType Warning { get; set; } = WFAnimations.AnimationType.Scale;




            }

            internal static void Play(WFAlert.Types type)
            {
                soundPlayer.Stream = soundLocation;
                switch (type)
                {
                    case Types.Success:
                        if (Success != Sounds.None)
                            soundPlayer.Play();
                        break;

                    case Types.Error:
                        if (Error != Sounds.None)
                            soundPlayer.Play();
                        break;

                    case Types.Info:
                        if (Info != Sounds.None)
                            soundPlayer.Play();
                        break;

                    case Types.Warning:
                        if (Warning != Sounds.None)
                            soundPlayer.Play();
                        break;
                }




            }
        }

        public static void Show(string message, WFAlert.Types type, bool closebutton = true)
        {
            AlertWindow alertfrm = new AlertWindow(message, type, closebutton, AlertMessage.Theme, AlertMessage.Style, AlertMessage.Font);
            switch (type)
            {
                case Types.Success:
                    AlertSounds.StreamSound(AlertSounds.Success);
                    break;
                case Types.Error:
                    AlertSounds.StreamSound(AlertSounds.Error);
                    break;
                case Types.Info:
                    AlertSounds.StreamSound(AlertSounds.Info);
                    break;
                case Types.Warning:
                    AlertSounds.StreamSound(AlertSounds.Warning);
                    break;
            }
            AlertSounds.Play(type);
        }


    }
}
