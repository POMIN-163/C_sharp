﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAPP_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Click += Form1_Click;
            this.listBox1.Click += ListBox1_Click;
            this.listBox1.Click += Form1_Click;
            listBox1.AllowDrop = true;
            Button a = new Button();
            List<string> b = new List<string>();
            b.Add("1");
            b.Add("1");
            b.Add("1");

            listBox1.DataSource = b;

        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2");
        }
    }
}
