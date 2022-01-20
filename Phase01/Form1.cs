using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Phase01
{
    public partial class GameForm : Form
    {
        int randomNumber;
        public GameForm()
        {
            InitializeComponent();
        }
            Random random = new Random();
        private void RbEasy_CheckedChanged(object sender, EventArgs e)
        {
            randomNumber = random.Next(1, 500);
        } 
        private void RbHard_CheckedChanged(object sender, EventArgs e)
        {
            randomNumber = random.Next(1, 2000);
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = true;
            BtnGuess.Enabled = true;
            TxtNumber.Enabled = true;
            BtnStart.Enabled = false;
            RbEasy.Hide();
            RbHard.Hide();
        }
        private void BtnGuess_Click(object sender, EventArgs e)
        {
            LbGuesses.Items.Add(TxtNumber.Text);
            if (TxtNumber.Text =="")
            {
                MessageBox.Show("Enter A Number From 1 - 10");
                TxtNumber.Focus();
            }
            else
            {
                if (randomNumber==int.Parse(TxtNumber.Text))
                {
                    StartTimer.Enabled = false;
                    MessageBox.Show("Your Guess Time Is: "+ LblShowTime.Text);
                    TxtNumber.Text= "";
                    TxtNumber.Enabled = false;
                    BtnGuess.Enabled = false;
                    LblHint.Text = "";
                    LblShowTime.Text = "0";
                    LbGuesses.Items.Clear();
                }
                else if (randomNumber > int.Parse(TxtNumber.Text))
                {
                    LblHint.ForeColor = Color.Black;
                    LblHint.Text = "Your Guess Is Lesser Than The Number";
                }
                else if (randomNumber < int.Parse(TxtNumber.Text))
                {
                    LblHint.ForeColor = Color.Black;
                    LblHint.Text = "Your Guess Is elder Than The Number";
                }
                TxtNumber.Text = "";
                TxtNumber.Focus();
            }
        }
        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            BtnStart.BackColor = Color.LightGreen;
        }
        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            BtnStart.BackColor = Color.LightYellow;

        }
        private void BtnGuess_MouseEnter(object sender, EventArgs e)
        {
            BtnGuess.BackColor = Color.Yellow;
            this.BtnGuess.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }

        private void BtnGuess_MouseLeave(object sender, EventArgs e)
        {
            BtnGuess.BackColor = Color.LightYellow;
            this.BtnGuess.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            LblShowTime.Text=(int.Parse(LblShowTime.Text)+ 1).ToString();
            if (LblShowTime.Text=="60")
            {
                MessageBox.Show("Sorry!You Cant Guess The Number.The Number Is "+randomNumber);
                TxtNumber.Text = "";
                TxtNumber.Enabled = false;
                BtnGuess.Enabled = false;
                StartTimer.Enabled = false;
                LblHint.Text = "";
                LblShowTime.Text = "0";
                LbGuesses.Items.Clear();
            }
        }


    }
}



      
    

