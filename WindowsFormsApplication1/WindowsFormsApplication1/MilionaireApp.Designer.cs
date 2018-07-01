namespace BecomeMilionaire
{
    partial class MilionaireApp
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTxtScreen = new System.Windows.Forms.RichTextBox();
            this.lblCurrentMoney = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.btnAnswerB = new BecomeMilionaire.ButtonExtentions();
            this.btnAnswerC = new BecomeMilionaire.ButtonExtentions();
            this.btnAnswerD = new BecomeMilionaire.ButtonExtentions();
            this.btnAnswerA = new BecomeMilionaire.ButtonExtentions();
            this.btnHint = new BecomeMilionaire.ButtonExtentions();
            this.btnQuit = new BecomeMilionaire.ButtonExtentions();
            this.btnStart = new BecomeMilionaire.ButtonExtentions();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTxtScreen
            // 
            this.richTxtScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtScreen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTxtScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTxtScreen.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTxtScreen.Location = new System.Drawing.Point(12, 13);
            this.richTxtScreen.Name = "richTxtScreen";
            this.richTxtScreen.ReadOnly = true;
            this.richTxtScreen.Size = new System.Drawing.Size(1100, 317);
            this.richTxtScreen.TabIndex = 4;
            this.richTxtScreen.Text = "";
            // 
            // lblCurrentMoney
            // 
            this.lblCurrentMoney.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrentMoney.AutoSize = true;
            this.lblCurrentMoney.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentMoney.Location = new System.Drawing.Point(1169, 297);
            this.lblCurrentMoney.Name = "lblCurrentMoney";
            this.lblCurrentMoney.Size = new System.Drawing.Size(32, 33);
            this.lblCurrentMoney.TabIndex = 12;
            this.lblCurrentMoney.Text = "0";
            this.lblCurrentMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswerB
            // 
            this.btnAnswerB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnswerB.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerB.Location = new System.Drawing.Point(291, 372);
            this.btnAnswerB.Name = "btnAnswerB";
            this.btnAnswerB.Size = new System.Drawing.Size(191, 60);
            this.btnAnswerB.TabIndex = 11;
            this.btnAnswerB.Text = "Answer B";
            this.btnAnswerB.UseVisualStyleBackColor = false;
            this.btnAnswerB.Click += new System.EventHandler(this.btnAnswerB_Click);
            // 
            // btnAnswerC
            // 
            this.btnAnswerC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnswerC.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerC.Location = new System.Drawing.Point(565, 372);
            this.btnAnswerC.Name = "btnAnswerC";
            this.btnAnswerC.Size = new System.Drawing.Size(191, 60);
            this.btnAnswerC.TabIndex = 10;
            this.btnAnswerC.Text = "Answer C";
            this.btnAnswerC.UseVisualStyleBackColor = false;
            this.btnAnswerC.Click += new System.EventHandler(this.btnAnswerC_Click);
            // 
            // btnAnswerD
            // 
            this.btnAnswerD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnswerD.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerD.Location = new System.Drawing.Point(850, 372);
            this.btnAnswerD.Name = "btnAnswerD";
            this.btnAnswerD.Size = new System.Drawing.Size(191, 60);
            this.btnAnswerD.TabIndex = 9;
            this.btnAnswerD.Text = "Answer D";
            this.btnAnswerD.UseVisualStyleBackColor = false;
            this.btnAnswerD.Click += new System.EventHandler(this.btnAnswerD_Click);
            // 
            // btnAnswerA
            // 
            this.btnAnswerA.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnswerA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAnswerA.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerA.Location = new System.Drawing.Point(33, 372);
            this.btnAnswerA.Name = "btnAnswerA";
            this.btnAnswerA.Size = new System.Drawing.Size(191, 60);
            this.btnAnswerA.TabIndex = 8;
            this.btnAnswerA.Text = "Answer A";
            this.btnAnswerA.UseVisualStyleBackColor = false;
            this.btnAnswerA.Click += new System.EventHandler(this.btnAnswerA_Click);
            // 
            // btnHint
            // 
            this.btnHint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHint.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnHint.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(1135, 200);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(120, 62);
            this.btnHint.TabIndex = 7;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnQuit.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(1135, 112);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(120, 62);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStart.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(1135, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 62);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MilionaireApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 473);
            this.Controls.Add(this.lblCurrentMoney);
            this.Controls.Add(this.btnAnswerB);
            this.Controls.Add(this.btnAnswerC);
            this.Controls.Add(this.btnAnswerD);
            this.Controls.Add(this.btnAnswerA);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.richTxtScreen);
            this.Name = "MilionaireApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Become a Milionaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTxtScreen;
        private ButtonExtentions btnStart;
        private ButtonExtentions btnQuit;
        private ButtonExtentions btnHint;
        private ButtonExtentions btnAnswerA;
        private ButtonExtentions btnAnswerD;
        private ButtonExtentions btnAnswerC;
        private ButtonExtentions btnAnswerB;
        private System.Windows.Forms.Label lblCurrentMoney;
        private System.Windows.Forms.Timer timerCount;
    }
}

