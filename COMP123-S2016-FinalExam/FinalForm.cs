﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
           
            StrengthTextBox.Text = Program.Character.Strength;
            DexterityTextBox.Text = Program.Character.Dexterity;
            ConstitutionTextBox.Text = Program.Character.Constitution;
            IntelligenceTextBox.Text = Program.Character.Intelligence;
            WisdomTextBox.Text = Program.Character.Wisdom;
            CharismaTextBox.Text = Program.Character.Charisma;
            FirstNameTextBox.Text = Program.Character.FirstName;
            LastNameTextBox.Text = Program.Character.LastName;
            RaceTextBox.Text = Program.Character.Race;
        }
    }
}
