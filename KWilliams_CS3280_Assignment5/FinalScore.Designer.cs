namespace KWilliams_CS3280_Assignment5
{
    partial class frmFinalScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalScore));
            this.lblFinalScoreHeader = new System.Windows.Forms.Label();
            this.lblFinalScoreMessage = new System.Windows.Forms.Label();
            this.lblUserFinalScore = new System.Windows.Forms.Label();
            this.lblSecondMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalScoreHeader
            // 
            this.lblFinalScoreHeader.AutoSize = true;
            this.lblFinalScoreHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblFinalScoreHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScoreHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalScoreHeader.Location = new System.Drawing.Point(155, 31);
            this.lblFinalScoreHeader.Name = "lblFinalScoreHeader";
            this.lblFinalScoreHeader.Size = new System.Drawing.Size(117, 24);
            this.lblFinalScoreHeader.TabIndex = 0;
            this.lblFinalScoreHeader.Text = "Final Score";
            // 
            // lblFinalScoreMessage
            // 
            this.lblFinalScoreMessage.AutoSize = true;
            this.lblFinalScoreMessage.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblFinalScoreMessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalScoreMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFinalScoreMessage.Location = new System.Drawing.Point(55, 232);
            this.lblFinalScoreMessage.Name = "lblFinalScoreMessage";
            this.lblFinalScoreMessage.Size = new System.Drawing.Size(0, 25);
            this.lblFinalScoreMessage.TabIndex = 2;
            // 
            // lblUserFinalScore
            // 
            this.lblUserFinalScore.AutoSize = true;
            this.lblUserFinalScore.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblUserFinalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserFinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFinalScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUserFinalScore.Location = new System.Drawing.Point(169, 128);
            this.lblUserFinalScore.Name = "lblUserFinalScore";
            this.lblUserFinalScore.Size = new System.Drawing.Size(2, 41);
            this.lblUserFinalScore.TabIndex = 1;
            // 
            // lblSecondMessage
            // 
            this.lblSecondMessage.AutoSize = true;
            this.lblSecondMessage.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSecondMessage.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSecondMessage.Location = new System.Drawing.Point(82, 271);
            this.lblSecondMessage.Name = "lblSecondMessage";
            this.lblSecondMessage.Size = new System.Drawing.Size(0, 25);
            this.lblSecondMessage.TabIndex = 3;
            // 
            // frmFinalScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 334);
            this.Controls.Add(this.lblSecondMessage);
            this.Controls.Add(this.lblFinalScoreMessage);
            this.Controls.Add(this.lblUserFinalScore);
            this.Controls.Add(this.lblFinalScoreHeader);
            this.Name = "frmFinalScore";
            this.Text = "Final Score";
            this.Load += new System.EventHandler(this.frmFinalScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFinalScoreHeader;
        private System.Windows.Forms.Label lblFinalScoreMessage;
        private System.Windows.Forms.Label lblUserFinalScore;
        private System.Windows.Forms.Label lblSecondMessage;
    }
}