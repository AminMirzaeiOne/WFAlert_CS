using System;
using System.Collections.Generic;
using System.Drawing;
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

        }

        public static void Show(string message, WFAlert.Types type, bool closebutton = true)
        {
            AlertWindow alertfrm = new AlertWindow(message, type, closebutton, AlertMessage.Theme, AlertMessage.Style, AlertMessage.Font);
        }


    }
}
