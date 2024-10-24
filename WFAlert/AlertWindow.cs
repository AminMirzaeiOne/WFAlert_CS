using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAlert
{
    internal partial class AlertWindow : Form
    {
        internal AlertWindow()
        {
            InitializeComponent();
        }
        private AlertMessage.Actions actions;
        private int x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.actions = AlertMessage.Actions.Close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.actions)
            {
                case AlertMessage.Actions.Wait:
                    timer1.Interval = 5000;
                    this.actions = AlertMessage.Actions.Close;
                    break;
                case AlertMessage.Actions.Start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.actions = AlertMessage.Actions.Wait;
                        }
                    }
                    break;
                case AlertMessage.Actions.Close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
