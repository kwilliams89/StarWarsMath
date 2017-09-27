namespace KWilliams_CS3280_Assignment5
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpGameModes = new System.Windows.Forms.GroupBox();
            this.pnlGameModes = new System.Windows.Forms.Panel();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.grpGameModes.SuspendLayout();
            this.pnlGameModes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(70, 47);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login/Edit Player";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // grpGameModes
            // 
            this.grpGameModes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpGameModes.Controls.Add(this.pnlGameModes);
            this.grpGameModes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpGameModes.Location = new System.Drawing.Point(61, 104);
            this.grpGameModes.Name = "grpGameModes";
            this.grpGameModes.Size = new System.Drawing.Size(284, 163);
            this.grpGameModes.TabIndex = 1;
            this.grpGameModes.TabStop = false;
            this.grpGameModes.Text = "Choose Game Mode:";
            // 
            // pnlGameModes
            // 
            this.pnlGameModes.Controls.Add(this.btnDivide);
            this.pnlGameModes.Controls.Add(this.btnAdd);
            this.pnlGameModes.Controls.Add(this.btnMultiply);
            this.pnlGameModes.Controls.Add(this.btnSubtract);
            this.pnlGameModes.Location = new System.Drawing.Point(7, 20);
            this.pnlGameModes.Name = "pnlGameModes";
            this.pnlGameModes.Size = new System.Drawing.Size(271, 137);
            this.pnlGameModes.TabIndex = 0;
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(152, 77);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(83, 39);
            this.btnDivide.TabIndex = 4;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 39);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(31, 77);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(83, 39);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(152, 18);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(83, 39);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.Enabled = false;
            this.btnHighScores.Location = new System.Drawing.Point(220, 47);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(112, 33);
            this.btnHighScores.TabIndex = 2;
            this.btnHighScores.Text = "High Scores";
            this.btnHighScores.UseVisualStyleBackColor = true;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(408, 308);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.grpGameModes);
            this.Controls.Add(this.btnLogin);
            this.Name = "MainScreen";
            this.Text = "Star Wars Math";
            this.grpGameModes.ResumeLayout(false);
            this.pnlGameModes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpGameModes;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Panel pnlGameModes;
    }
}