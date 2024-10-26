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

    public enum Animations
    {
        Rotate,
        HorizSlide,
        VertSlide,
        Scale,
        ScaleAndRotate,
        HorizSlideAndRotate,
        ScaleAndHorizSlide,
        Transparent,
        Leaf,
        Mosaic,
        Particles,
        VertBlind,
        HorizBlind
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

        public struct AlertAnimation
        {
            internal static WFAnimations.AnimationType successType = WFAnimations.AnimationType.Scale;
            internal static WFAnimations.AnimationType errorType = WFAnimations.AnimationType.Scale;
            internal static WFAnimations.AnimationType infoType = WFAnimations.AnimationType.Scale;
            internal static WFAnimations.AnimationType warningType = WFAnimations.AnimationType.Scale;

            private static WFAlert.Animations success = WFAlert.Animations.Scale;
            private static WFAlert.Animations error = WFAlert.Animations.Scale;
            private static WFAlert.Animations info = WFAlert.Animations.Scale;
            private static WFAlert.Animations warning = WFAlert.Animations.Scale;



            public static WFAlert.Animations Success
            {
                get { return AlertMessage.AlertAnimation.success; }
                set
                {
                    AlertMessage.AlertAnimation.success = value;
                    switch (value)
                    {
                        case Animations.Scale:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Scale;
                            break;
                        case Animations.Rotate:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Rotate;
                            break;
                        case Animations.Transparent:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Transparent;
                            break;
                        case Animations.Particles:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Particles;
                            break;
                        case Animations.Mosaic:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Mosaic;
                            break;
                        case Animations.Leaf:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.Leaf;
                            break;
                        case Animations.HorizSlideAndRotate:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.HorizSlideAndRotate;
                            break;
                        case Animations.HorizBlind:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.HorizBlind;
                            break;
                        case Animations.VertBlind:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.VertBlind;
                            break;
                        case Animations.VertSlide:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.VertSlide;
                            break;
                        case Animations.HorizSlide:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.HorizSlide;
                            break;
                        case Animations.ScaleAndRotate:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.ScaleAndRotate;
                            break;
                        case Animations.ScaleAndHorizSlide:
                            AlertMessage.AlertAnimation.successType = WFAnimations.AnimationType.ScaleAndHorizSlide;
                            break;
                    }
                }
            }
            public static WFAlert.Animations Error
            {
                get { return AlertMessage.AlertAnimation.error; }
                set
                {
                    AlertMessage.AlertAnimation.error = value;
                    switch (value)
                    {
                        case Animations.Scale:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Scale;
                            break;
                        case Animations.Rotate:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Rotate;
                            break;
                        case Animations.Transparent:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Transparent;
                            break;
                        case Animations.Particles:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Particles;
                            break;
                        case Animations.Mosaic:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Mosaic;
                            break;
                        case Animations.Leaf:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.Leaf;
                            break;
                        case Animations.HorizSlideAndRotate:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.HorizSlideAndRotate;
                            break;
                        case Animations.HorizBlind:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.HorizBlind;
                            break;
                        case Animations.VertBlind:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.VertBlind;
                            break;
                        case Animations.VertSlide:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.VertSlide;
                            break;
                        case Animations.HorizSlide:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.HorizSlide;
                            break;
                        case Animations.ScaleAndRotate:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.ScaleAndRotate;
                            break;
                        case Animations.ScaleAndHorizSlide:
                            AlertMessage.AlertAnimation.errorType = WFAnimations.AnimationType.ScaleAndHorizSlide;
                            break;
                    }
                }
            }
            public static WFAlert.Animations Info
            {
                get { return AlertMessage.AlertAnimation.info; }
                set
                {
                    AlertMessage.AlertAnimation.info = value;
                    switch (value)
                    {
                        case Animations.Scale:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Scale;
                            break;
                        case Animations.Rotate:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Rotate;
                            break;
                        case Animations.Transparent:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Transparent;
                            break;
                        case Animations.Particles:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Particles;
                            break;
                        case Animations.Mosaic:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Mosaic;
                            break;
                        case Animations.Leaf:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.Leaf;
                            break;
                        case Animations.HorizSlideAndRotate:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.HorizSlideAndRotate;
                            break;
                        case Animations.HorizBlind:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.HorizBlind;
                            break;
                        case Animations.VertBlind:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.VertBlind;
                            break;
                        case Animations.VertSlide:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.VertSlide;
                            break;
                        case Animations.HorizSlide:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.HorizSlide;
                            break;
                        case Animations.ScaleAndRotate:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.ScaleAndRotate;
                            break;
                        case Animations.ScaleAndHorizSlide:
                            AlertMessage.AlertAnimation.infoType = WFAnimations.AnimationType.ScaleAndHorizSlide;
                            break;
                    }
                }
            }
            public static WFAlert.Animations Warning
            {
                get { return AlertMessage.AlertAnimation.warning; }
                set
                {
                    AlertMessage.AlertAnimation.warning = value;
                    switch (value)
                    {
                        case Animations.Scale:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Scale;
                            break;
                        case Animations.Rotate:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Rotate;
                            break;
                        case Animations.Transparent:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Transparent;
                            break;
                        case Animations.Particles:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Particles;
                            break;
                        case Animations.Mosaic:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Mosaic;
                            break;
                        case Animations.Leaf:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.Leaf;
                            break;
                        case Animations.HorizSlideAndRotate:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.HorizSlideAndRotate;
                            break;
                        case Animations.HorizBlind:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.HorizBlind;
                            break;
                        case Animations.VertBlind:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.VertBlind;
                            break;
                        case Animations.VertSlide:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.VertSlide;
                            break;
                        case Animations.HorizSlide:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.HorizSlide;
                            break;
                        case Animations.ScaleAndRotate:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.ScaleAndRotate;
                            break;
                        case Animations.ScaleAndHorizSlide:
                            AlertMessage.AlertAnimation.warningType = WFAnimations.AnimationType.ScaleAndHorizSlide;
                            break;
                    }
                }
            }

            public static System.Boolean Upside { get; set; } = true;

            public static System.Int32 AnimationTime = 1500;

            public static System.Single TimeStep = 0.02f;
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
