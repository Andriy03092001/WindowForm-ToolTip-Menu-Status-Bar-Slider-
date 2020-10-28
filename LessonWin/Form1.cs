using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LessonWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.myBtn, "My text"); //Підказка при наведені на кнопку


        }

        private void myBtn_Click(object sender, EventArgs e)
        {
            this.statusProgressBar.Minimum = 0;
            this.statusProgressBar.Maximum = 100;
            this.statusProgressBar.Step = 2;

            this.txtStatus.Text = "Starting";
            this.statusProgressBar.Visible = true;
            this.Update();
            for (int i = 0; i < 100; i++)
            {
                this.statusProgressBar.PerformStep();
                Thread.Sleep(20);
                if (i == 99)
                {
                    this.txtStatus.Text = "Ready";
                    this.statusProgressBar.Visible = false;
                    this.Update();
                }

            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cropImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        public Color getColor()
        {
            Color c = Color.FromArgb(
                   this.sliderRed.Value,
                   this.sliderGreen.Value,
                   this.sliderBlue.Value
               );

            return c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = getColor();
        }

        private void sliderRed_ValueChanged(object sender, EventArgs e)
        {
            this.currentColor.BackColor = getColor();
        }

        private void sliderGreen_ValueChanged(object sender, EventArgs e)
        {
            this.currentColor.BackColor = getColor();
        }

        private void sliderBlue_ValueChanged(object sender, EventArgs e)
        {
            this.currentColor.BackColor = getColor();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
        }
    }
}
