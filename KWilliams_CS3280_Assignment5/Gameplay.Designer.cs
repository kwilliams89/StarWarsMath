namespace KWilliams_CS3280_Assignment5
{
    partial class frmGameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameScreen));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblQuestionNum = new System.Windows.Forms.Label();
            this.lblMathQuestion = new System.Windows.Forms.Label();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(255, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(255, 104);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblQuestionNum
            // 
            this.lblQuestionNum.AutoSize = true;
            this.lblQuestionNum.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblQuestionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblQuestionNum.Location = new System.Drawing.Point(96, 49);
            this.lblQuestionNum.Name = "lblQuestionNum";
            this.lblQuestionNum.Size = new System.Drawing.Size(86, 20);
            this.lblQuestionNum.TabIndex = 3;
            this.lblQuestionNum.Text = "Question #";
            // 
            // lblMathQuestion
            // 
            this.lblMathQuestion.AutoSize = true;
            this.lblMathQuestion.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblMathQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathQuestion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMathQuestion.Location = new System.Drawing.Point(42, 111);
            this.lblMathQuestion.Name = "lblMathQuestion";
            this.lblMathQuestion.Size = new System.Drawing.Size(67, 24);
            this.lblMathQuestion.TabIndex = 4;
            this.lblMathQuestion.Text = "1 + 2 =";
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.Location = new System.Drawing.Point(125, 115);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.Size = new System.Drawing.Size(85, 20);
            this.txtUserAnswer.TabIndex = 5;
            this.txtUserAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserAnswer_KeyPress);
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutcome.Location = new System.Drawing.Point(65, 78);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(0, 20);
            this.lblOutcome.TabIndex = 6;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(133, 12);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 20);
            this.lblTimer.TabIndex = 7;
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(362, 165);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.lblMathQuestion);
            this.Controls.Add(this.lblQuestionNum);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Name = "frmGameScreen";
            this.Text = "Star Wars Math";
            this.Load += new System.EventHandler(this.frmGameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblQuestionNum;
        private System.Windows.Forms.Label lblMathQuestion;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblTimer;
    }
}