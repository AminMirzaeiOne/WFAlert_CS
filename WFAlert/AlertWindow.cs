using System;
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
        internal AlertWindow(string message,WFAlert.Types type,bool closebutton,WFAlert.Themes theme,WFAlert.Styles style,Font font,WFAnimations.AnimationType animationtype)
        {
            InitializeComponent();
            this.Message = message;
            this.type = type;
            this.Theme = theme;
            this.Style = style;
            this.MessageFont = font;
            this.CloseButton = closebutton;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alertwindow" + i.ToString();
                AlertWindow frm = (AlertWindow)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - 10;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case WFAlert.Types.Success:
                    this.label1.Text = "";
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
            this.tableLayoutPanel1.Visible = false;
            this.animator1.Show(this.tableLayoutPanel1);
            this.timer1.Interval = 5000;
            this.timer1.Start();

        }


        private System.Drawing.Color themeBackColor = Color.Green;
        private readonly System.Drawing.Color themeForeColor = Color.White;
        private WFAlert.Themes theme = Themes.Light;
        private WFAlert.Styles style = Styles.Border;
        private WFAlert.Types type = Types.Success;
        private WFAlert.Actions action = Actions.Start;
        private int x, y;


        internal Font MessageFont
        {
            get { return this.label2.Font; }
            set
            {
                this.label2.Font = value;
            }
        }

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
                        this.panel1.BackColor = Color.White;
                    }
                    else
                    {
                        this.panel1.BackColor = Color.FromArgb(20, 20, 20);
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
                            this.tableLayoutPanel1.BackColor = Color.DarkOrange;
                            this.label1.ForeColor = Color.DarkOrange;
                            this.label2.ForeColor = Color.DarkOrange;
                            this.button1.ForeColor = Color.DarkOrange;
                            break;
                    }
                }
                else
                {
                    switch (this.type)
                    {
                        case Types.Success:
                            this.panel1.BackColor = Color.Green;
                            break;
                        case Types.Error:
                            this.panel1.BackColor = Color.Crimson;
                            break;
                        case Types.Info:
                            this.panel1.BackColor = Color.DodgerBlue;
                            break;
                        case Types.Warning:
                            this.panel1.BackColor = Color.DarkOrange;
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
                            this.panel1.BackColor = Color.Green;
                            break;
                        case Types.Error:
                            this.panel1.BackColor = Color.Crimson;
                            break;
                        case Types.Info:
                            this.panel1.BackColor = Color.DodgerBlue;
                            break;
                        case Types.Warning:
                            this.panel1.BackColor = Color.DarkOrange;
                            break;
                    }
                    this.tableLayoutPanel1.BackColor = this.panel1.BackColor;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.animator1.Hide(this.tableLayoutPanel1);
            this.timer2.Start();
            this.timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.timer2.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
