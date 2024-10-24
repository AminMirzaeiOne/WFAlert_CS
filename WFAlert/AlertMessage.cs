using System;
using System.Collections.Generic;
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


    public static class AlertMessage
    {
        public static WFAlert.Themes Theme { get; set; } = WFAlert.Themes.Light;
        public static WFAlert.Styles Style { get; set; } = WFAlert.Styles.Border;

        public static void Show(string message,WFAlert.Types type)
        {
            AlertWindow alertfrm = new AlertWindow(message, type, AlertMessage.Theme, AlertMessage.Style); ;
        }


    }
}
