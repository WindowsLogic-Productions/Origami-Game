using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Origami_Game
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OrigamiButton_Click(object sender, EventArgs e)
        {
            int value = int.Parse(Label1.Text);
            int addToLabel = value + 1;
            Label1.Text = addToLabel.ToString();

            if (Label1.Text == "4")
            {
                Label1.Text = "3";
            }

            Properties.Settings.Default.TurnCount = Label1.Text;

            if (OrigamiButton.Text == "1")
            {
                MessageBox.Show("Counted 1 open.");
                OrigamiButton.Text = "5";
                OrigamiButton2.Text = "6";
                OrigamiButton3.Text = "7";
                OrigamiButton4.Text = "8";
            }else if (OrigamiButton.Text == "5")
            {
                MessageBox.Show("Counted 5 opens.");
                OrigamiButton.Text = "Red";
                OrigamiButton2.Text = "Green";
                OrigamiButton3.Text = "Blue";
                OrigamiButton4.Text = "Yellow";
            }

            if (Label1.Text == "3" & OrigamiButton.Text == "5")
            {
                MessageBox.Show("Result: You're a cutie!");
            }
        }

        private void OrigamiButton2_Click(object sender, EventArgs e)
        {

        }

        private void OrigamiButton3_Click(object sender, EventArgs e)
        {

        }

        private void OrigamiButton4_Click(object sender, EventArgs e)
        {

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrigamiButton.Text = "1";
            OrigamiButton2.Text = "4";
            OrigamiButton3.Text = "2";
            OrigamiButton4.Text = "3";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Origami Game " + Application.ProductVersion + "\n\n" + "Made by WindowsLogic Productions", "About Origami Game");
        }
    }
}
