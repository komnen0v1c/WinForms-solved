﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4._1
{
    public partial class AddGuest : Form
    {
        public AddGuest()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            GuestModel.Surname = SurnameTextBox.Text;
            GuestModel.Members = Convert.ToInt32(MembersComboBox.SelectedItem.ToString());
            GuestModel.Meals = "";
            foreach (CheckBox cb in MealsGroupBox.Controls)
            {
                if (cb.Checked)
                {
                    GuestModel.Meals += cb.Text + "\r\n";
                }
            }
        }
    }
}
