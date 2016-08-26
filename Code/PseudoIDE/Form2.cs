using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PseudoIDE
{
    public partial class Form2 : Form
    {
        Form1 form = new Form1();

        int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 15)
            {
                timer1.Stop();
                form.Show();
                form.FormClosed += new FormClosedEventHandler(form1_FormClosed);
                this.Hide();
            }
        }

        private void form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
