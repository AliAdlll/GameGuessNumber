
namespace Phase01
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.BtnGuess = new System.Windows.Forms.Button();
            this.LblEnterNumber = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.LbGuesses = new System.Windows.Forms.ListBox();
            this.LblYourGuesses = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblShowTime = new System.Windows.Forms.Label();
            this.LblHint = new System.Windows.Forms.Label();
            this.RbEasy = new System.Windows.Forms.RadioButton();
            this.RbHard = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxtNumber
            // 
            this.TxtNumber.Enabled = false;
            this.TxtNumber.Location = new System.Drawing.Point(73, 104);
            this.TxtNumber.Multiline = true;
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(235, 26);
            this.TxtNumber.TabIndex = 1;
            this.TxtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumber_KeyPress);
            // 
            // BtnGuess
            // 
            this.BtnGuess.BackColor = System.Drawing.Color.LightYellow;
            this.BtnGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuess.Enabled = false;
            this.BtnGuess.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnGuess.Location = new System.Drawing.Point(73, 163);
            this.BtnGuess.Name = "BtnGuess";
            this.BtnGuess.Size = new System.Drawing.Size(235, 43);
            this.BtnGuess.TabIndex = 1;
            this.BtnGuess.Text = "Guess";
            this.BtnGuess.UseVisualStyleBackColor = false;
            this.BtnGuess.Click += new System.EventHandler(this.BtnGuess_Click);
            this.BtnGuess.MouseEnter += new System.EventHandler(this.BtnGuess_MouseEnter);
            this.BtnGuess.MouseLeave += new System.EventHandler(this.BtnGuess_MouseLeave);
            // 
            // LblEnterNumber
            // 
            this.LblEnterNumber.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEnterNumber.ForeColor = System.Drawing.Color.Black;
            this.LblEnterNumber.Location = new System.Drawing.Point(73, 48);
            this.LblEnterNumber.Name = "LblEnterNumber";
            this.LblEnterNumber.Size = new System.Drawing.Size(235, 32);
            this.LblEnterNumber.TabIndex = 2;
            this.LblEnterNumber.Text = "Enter A Number";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.LightYellow;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(73, 322);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(235, 81);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.BtnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.BtnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // StartTimer
            // 
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // LbGuesses
            // 
            this.LbGuesses.BackColor = System.Drawing.Color.LightYellow;
            this.LbGuesses.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbGuesses.FormattingEnabled = true;
            this.LbGuesses.ItemHeight = 26;
            this.LbGuesses.Location = new System.Drawing.Point(516, 104);
            this.LbGuesses.Name = "LbGuesses";
            this.LbGuesses.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LbGuesses.Size = new System.Drawing.Size(193, 186);
            this.LbGuesses.TabIndex = 6;
            // 
            // LblYourGuesses
            // 
            this.LblYourGuesses.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblYourGuesses.Location = new System.Drawing.Point(516, 48);
            this.LblYourGuesses.Name = "LblYourGuesses";
            this.LblYourGuesses.Size = new System.Drawing.Size(193, 32);
            this.LblYourGuesses.TabIndex = 7;
            this.LblYourGuesses.Text = "Your Guesses";
            // 
            // LblTime
            // 
            this.LblTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTime.Location = new System.Drawing.Point(516, 367);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(80, 36);
            this.LblTime.TabIndex = 8;
            this.LblTime.Text = "Time";
            // 
            // LblShowTime
            // 
            this.LblShowTime.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblShowTime.Location = new System.Drawing.Point(645, 367);
            this.LblShowTime.Name = "LblShowTime";
            this.LblShowTime.Size = new System.Drawing.Size(64, 36);
            this.LblShowTime.TabIndex = 9;
            this.LblShowTime.Text = "0";
            // 
            // LblHint
            // 
            this.LblHint.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblHint.Location = new System.Drawing.Point(73, 233);
            this.LblHint.Name = "LblHint";
            this.LblHint.Size = new System.Drawing.Size(235, 69);
            this.LblHint.TabIndex = 10;
            // 
            // RbEasy
            // 
            this.RbEasy.AutoSize = true;
            this.RbEasy.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RbEasy.Location = new System.Drawing.Point(73, 432);
            this.RbEasy.Name = "RbEasy";
            this.RbEasy.Size = new System.Drawing.Size(85, 37);
            this.RbEasy.TabIndex = 11;
            this.RbEasy.Text = "Easy";
            this.RbEasy.UseVisualStyleBackColor = true;
            this.RbEasy.CheckedChanged += new System.EventHandler(this.RbEasy_CheckedChanged);
            // 
            // RbHard
            // 
            this.RbHard.AutoSize = true;
            this.RbHard.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RbHard.Location = new System.Drawing.Point(73, 477);
            this.RbHard.Name = "RbHard";
            this.RbHard.Size = new System.Drawing.Size(88, 37);
            this.RbHard.TabIndex = 12;
            this.RbHard.Text = "Hard";
            this.RbHard.UseVisualStyleBackColor = true;
            this.RbHard.CheckedChanged += new System.EventHandler(this.RbHard_CheckedChanged);
            // 
            // GameForm
            // 
            this.AcceptButton = this.BtnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1193, 672);
            this.Controls.Add(this.RbHard);
            this.Controls.Add(this.RbEasy);
            this.Controls.Add(this.LblHint);
            this.Controls.Add(this.LblShowTime);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.LblYourGuesses);
            this.Controls.Add(this.LbGuesses);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LblEnterNumber);
            this.Controls.Add(this.BtnGuess);
            this.Controls.Add(this.TxtNumber);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Button BtnGuess;
        private System.Windows.Forms.Label LblEnterNumber;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.ListBox LbGuesses;
        private System.Windows.Forms.Label LblYourGuesses;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblShowTime;
        private System.Windows.Forms.Label LblHint;
        private System.Windows.Forms.RadioButton RbEasy;
        private System.Windows.Forms.RadioButton RbHard;
    }
}

