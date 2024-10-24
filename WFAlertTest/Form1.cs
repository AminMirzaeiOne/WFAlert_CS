using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAlertTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WFAlert.AlertMessage.Style = WFAlert.Styles.Fill;
            WFAlert.AlertMessage.Theme = WFAlert.Themes.Dark;
            WFAlert.AlertMessage.Font = new Font("Segoe UI", 11, FontStyle.Italic);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Success,true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Warning,true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Error,false);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Warning Message", WFAlert.Types.Info,false);

        }
    }
}
