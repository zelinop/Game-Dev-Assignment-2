﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class VerbsLvl2Q1 : Form
    {
        public VerbsLvl2Q1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Change")
            {
                textBox1.ForeColor = Color.Green;
                MessageBox.Show("Correct!");
                this.Hide();
                VerbsLvl2Q2 start = new VerbsLvl2Q2();
                start.Show();
            }
            else
            {
                textBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect!");
                this.Hide();
                VerbsLvl2Q2 start = new VerbsLvl2Q2();
                start.Show();

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }
    }
}
