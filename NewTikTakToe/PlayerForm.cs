﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewTikTakToe
{
    public partial class PlayerForm : Form
    {

        public PlayerForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string marker = "X";
            PlayForm playForm = new PlayForm(marker);
            playForm.marker = marker;
            this.Hide();
            playForm.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string marker = "O";
            PlayForm playForm = new PlayForm(marker);
            playForm.marker = marker;
            this.Hide();
            playForm.Show();
            
        }

        private void PlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
