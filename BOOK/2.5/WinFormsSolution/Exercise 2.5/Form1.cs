﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NonModalFormButton_Click(object sender, EventArgs e)
        {
            NonmodalForm nf = new NonmodalForm();

            nf.Show();
        }

        private void ModalFormButton_Click(object sender, EventArgs e)
        {
            NonmodalForm nf = new NonmodalForm();
            nf.ShowDialog();
            nf.Dispose();
        }
    }
}
