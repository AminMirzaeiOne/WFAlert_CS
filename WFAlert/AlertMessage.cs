using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAlert
{
    public class AlertMessage
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

        private AlertMessage.Actions actions = Actions.Start;


    }
}
