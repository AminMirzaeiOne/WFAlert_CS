using System;
using System.Collections.Generic;
using System.Linq;
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


    public class AlertMessage
    {
        private WFAlert.Themes theme = Themes.Light;
        
        public WFAlert.Themes Theme
        {
            get { return this.theme; }
            set
            {
                this.theme = value;
            }
        }



    }
}
