﻿using System;
using System.Windows.Forms;

namespace Ex_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txt_day.Text = dateTimePicker1.Value.Day.ToString();
            txt_month.Text = dateTimePicker1.Value.Month.ToString();
            txt_year.Text = dateTimePicker1.Value.Year.ToString();

            txt_dayname.Text = dateTimePicker1.Value.ToString("dddd");
            txt_monthname.Text = dateTimePicker1.Value.ToString("MMMM");
        }
    }
}