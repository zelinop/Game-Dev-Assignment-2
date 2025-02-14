﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Learn_Japanese_Assignment_2
{
    public partial class PronounsLvl1Learn : Form
    {
        public PronounsLvl1Learn()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Category start = new Category();
            start.Show();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you ready to start the quiz?";
            string title = "Start?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                PronounsLvl1Q1 start = new PronounsLvl1Q1();
                start.Show();
            }
        }
    }
}
