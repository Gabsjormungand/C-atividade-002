﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__atividade_002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu primeiro programa C#.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi!");
            MessageBox.Show("Tudo bem ?");
        }
    }
}
