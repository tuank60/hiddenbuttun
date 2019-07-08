using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hiddenbutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "▼ Assessment")
            {
                panel1.Height = 133;
                label2.Text = "▶ Assessment";
                panel2.Top = panel1.Top + panel1.Height + 20;
            }
            else if (label2.Text == "▶ Assessment")
            {
                panel1.Height = 26;
                label2.Text = "▼ Assessment";
                panel2.Top = panel1.Top + panel1.Height + 20;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (label3.Text == "▼ Temperature")
            {
                panel2.Top = panel1.Top + panel1.Height + 20;
                panel2.Height = 148;
                label3.Text = "▶ Temperature";
            }
            else if (label3.Text == "▶ Temperature")
            {
                panel2.Height = 26;
                label3.Text = "▼ Temperature";
                panel2.Top = panel1.Top + panel1.Height + 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Height = 20;
            panel2.Height = 20;
            panel2.Top = panel1.Top + panel1.Height + 20;
        }
    }
}
