/* 
 Matthew Arndt
 2/5/19
 This is the file where all of the form elements are inititalized.
 Starting attributes are also declared here.
 */
namespace ArndtBingo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblReadyToPlay = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRandNum = new System.Windows.Forms.TextBox();
            this.btnDontHave = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.lblYourBingoCard = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblWelcome.Location = new System.Drawing.Point(49, 7);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(400, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the game of BINGO";
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEnterName.Location = new System.Drawing.Point(80, 64);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(234, 25);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter Your Name to Start:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(338, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(110, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblReadyToPlay
            // 
            this.lblReadyToPlay.AutoSize = true;
            this.lblReadyToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblReadyToPlay.Location = new System.Drawing.Point(151, 114);
            this.lblReadyToPlay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReadyToPlay.Name = "lblReadyToPlay";
            this.lblReadyToPlay.Size = new System.Drawing.Size(197, 24);
            this.lblReadyToPlay.TabIndex = 3;
            this.lblReadyToPlay.Text = "Are you ready to play?";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.LimeGreen;
            this.btnYes.Location = new System.Drawing.Point(92, 152);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(96, 55);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Location = new System.Drawing.Point(310, 152);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(97, 55);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "No, Exit";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(35, 232);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(430, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "We call one number at a time. Check your card for that number and if found click " +
    "that cell.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "We will do the rest, checking for a BINGO or not. The number called will appear b" +
    "elow.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "If you do not have the number called in your card click the \"Dont Have\" button be" +
    "low.";
            // 
            // txtRandNum
            // 
            this.txtRandNum.Location = new System.Drawing.Point(184, 366);
            this.txtRandNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRandNum.Name = "txtRandNum";
            this.txtRandNum.ReadOnly = true;
            this.txtRandNum.Size = new System.Drawing.Size(122, 20);
            this.txtRandNum.TabIndex = 9;
            // 
            // btnDontHave
            // 
            this.btnDontHave.Location = new System.Drawing.Point(184, 399);
            this.btnDontHave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDontHave.Name = "btnDontHave";
            this.btnDontHave.Size = new System.Drawing.Size(122, 37);
            this.btnDontHave.TabIndex = 10;
            this.btnDontHave.Text = "Don\'t Have";
            this.btnDontHave.UseVisualStyleBackColor = true;
            this.btnDontHave.Click += new System.EventHandler(this.btnDontHave_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Location = new System.Drawing.Point(524, 52);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(610, 555);
            this.pnlCard.TabIndex = 11;
            // 
            // lblYourBingoCard
            // 
            this.lblYourBingoCard.AutoSize = true;
            this.lblYourBingoCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblYourBingoCard.Location = new System.Drawing.Point(779, 18);
            this.lblYourBingoCard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYourBingoCard.Name = "lblYourBingoCard";
            this.lblYourBingoCard.Size = new System.Drawing.Size(117, 18);
            this.lblYourBingoCard.TabIndex = 12;
            this.lblYourBingoCard.Text = "Your Bingo Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(335, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "You must enter a name to play";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblYourBingoCard);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.btnDontHave);
            this.Controls.Add(this.txtRandNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblReadyToPlay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Bingo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblReadyToPlay;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRandNum;
        private System.Windows.Forms.Button btnDontHave;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblYourBingoCard;
        private System.Windows.Forms.Label label3;
    }
}

