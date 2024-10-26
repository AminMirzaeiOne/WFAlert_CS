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
            WFAlert.AlertMessage.Animation = true;
            WFAlert.AlertMessage.AlertAnimation.TimeStep = 0.01f;
            WFAlert.AlertMessage.AlertAnimation.Success = WFAlert.Animations.Mosaic;
            WFAlert.AlertMessage.AlertAnimation.Warning = WFAlert.Animations.ScaleAndRotate;
            WFAlert.AlertMessage.AlertAnimation.Info = WFAlert.Animations.Leaf;
            WFAlert.AlertMessage.AlertAnimation.Error = WFAlert.Animations.Particles;
            WFAlert.AlertMessage.Style = WFAlert.Styles.Fill;
            WFAlert.AlertMessage.Theme = WFAlert.Themes.Dark;
            WFAlert.AlertMessage.Font = new Font("Segoe UI", 11, FontStyle.Italic);
            WFAlert.AlertMessage.AlertSounds.Success = WFAlert.Sounds.DSound;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Success,true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Warning Message", WFAlert.Types.Warning,true);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Error Message", WFAlert.Types.Error,true);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Information Message", WFAlert.Types.Info,true);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == 0)
            {
                WFAlert.AlertMessage.Theme = WFAlert.Themes.Light;
            }
            else
            {
                WFAlert.AlertMessage.Theme = WFAlert.Themes.Dark;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                WFAlert.AlertMessage.Style = WFAlert.Styles.Fill;
            }
            else
            {
                WFAlert.AlertMessage.Style = WFAlert.Styles.Border;
            }
        }
    }
}
