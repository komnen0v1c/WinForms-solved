﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ModalButton_Click(object sender, EventArgs e)
        {
            NewForm nf = new NewForm();
            InfoModel.Information = "You have opened Modal form!";

            nf.ShowDialog();
        }

        private void NonModalButton_Click(object sender, EventArgs e)
        {
            NewForm nf = new NewForm();
            InfoModel.Information = "You have opened Non-Modal form!";

            nf.Show();
        }
    }
}
