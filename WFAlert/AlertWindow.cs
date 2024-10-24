﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAlert
{
    internal partial class AlertWindow : Form
    {
        internal AlertWindow(string message,WFAlert.Types type,WFAlert.Themes theme,WFAlert.Styles style)
        {
            InitializeComponent();
            this.Message = message;
            this.type = type;
            this.Theme = theme;
            this.Style = style;

            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertWindow frm = (AlertWindow)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case WFAlert.Types.Success:
                    this.label1.Text = "";
                    break;
                case WFAlert.Types.Error:
                    this.label1.Text = "";
                    break;
                case WFAlert.Types.Info:
                    this.label1.Text = "";
                    break;
                case WFAlert.Types.Warning:
                    this.label1.Text = "";
                    break;
            }


            this.label2.Text = message;

            this.Show();
            this.action = WFAlert.Actions.Start;
            this.timer1.Interval = 1;
            this.timer1.Start();

        }


        private System.Drawing.Color themeBackColor = Color.Green;
        private readonly System.Drawing.Color themeForeColor = Color.White;
        private WFAlert.Themes theme = Themes.Light;
        private WFAlert.Styles style = Styles.Border;
        private WFAlert.Types type = Types.Success;
        private WFAlert.Actions action = Actions.Start;
        private int x, y;


        internal WFAlert.Themes Theme
        {
            get { return this.theme; }
            set
            {
                this.theme = value;
                if (this.Style == Styles.Border)
                {
                    if (value == Themes.Light)
                    {
                        this.BackColor = Color.White;
                    }
                    else
                    {
                        this.BackColor = Color.FromArgb(20, 20, 20);
                    }

                    switch (this.type)
                    {
                        case Types.Success:
                            this.tableLayoutPanel1.BackColor = Color.Green;
                            this.label1.ForeColor = Color.Green;
                            this.label2.ForeColor = Color.Green;
                            this.button1.ForeColor = Color.Green;
                            break;

                        case Types.Error:
                            this.tableLayoutPanel1.BackColor = Color.Crimson;
                            this.label1.ForeColor = Color.Crimson;
                            this.label2.ForeColor = Color.Crimson;
                            this.button1.ForeColor = Color.Crimson;
                            break;

                        case Types.Info:
                            this.tableLayoutPanel1.BackColor = Color.DodgerBlue;
                            this.label1.ForeColor = Color.DodgerBlue;
                            this.label2.ForeColor = Color.DodgerBlue;
                            this.button1.ForeColor = Color.DodgerBlue;
                            break;

                        case Types.Warning:
                            this.tableLayoutPanel1.BackColor = Color.Coral;
                            this.label1.ForeColor = Color.Coral;
                            this.label2.ForeColor = Color.Coral;
                            this.button1.ForeColor = Color.Coral;
                            break;
                    }
                }
                else
                {
                    switch (this.type)
                    {
                        case Types.Success:
                            this.BackColor = Color.Green;
                            break;
                        case Types.Error:
                            this.BackColor = Color.Crimson;
                            break;
                        case Types.Info:
                            this.BackColor = Color.DodgerBlue;
                            break;
                        case Types.Warning:
                            this.BackColor = Color.Coral;
                            break;
                    }

                    this.tableLayoutPanel1.BackColor = this.themeForeColor;
                    this.label1.ForeColor = this.themeForeColor;
                    this.label2.ForeColor = this.themeForeColor;
                    this.button1.ForeColor = this.themeForeColor;
                }

                
            }

            
        }

        internal WFAlert.Styles Style
        {
            get { return this.style; }
            set
            {
                this.style = value;
                if(this.Style == Styles.Border)
                {
                    this.Theme = this.theme;
                }
                else
                {
                    switch (this.type) 
                    {
                        case Types.Success:
                            this.BackColor = Color.Green;
                            break;
                        case Types.Error:
                            this.BackColor = Color.Crimson;
                            break;
                        case Types.Info:
                            this.BackColor = Color.DodgerBlue;
                            break;
                        case Types.Warning:
                            this.BackColor = Color.Coral;
                            break;
                    }

                    this.tableLayoutPanel1.BackColor = this.themeForeColor;
                    this.label1.ForeColor = this.themeForeColor;
                    this.label2.ForeColor = this.themeForeColor;
                    this.button1.ForeColor = this.themeForeColor;
                }
            }
        }

        internal System.String Message
        {
            get { return this.label2.Text; }
            set
            {
                this.label2.Text = value;
            }
        }

        internal System.Boolean CloseButton { get { return this.button1.Visible; } set { this.button1.Visible = value; } }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = WFAlert.Actions.Close;
        }
    }
}
