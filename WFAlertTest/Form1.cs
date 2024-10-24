﻿using System;
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
            WFAlert.AlertMessage.Style = WFAlert.Styles.Border;
            WFAlert.AlertMessage.Theme = WFAlert.Themes.Dark;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Success);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Warning);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            WFAlert.AlertMessage.Show("Success Message", WFAlert.Types.Info);

        }
    }
}
