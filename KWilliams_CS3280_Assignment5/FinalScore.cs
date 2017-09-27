using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace KWilliams_CS3280_Assignment5
{
    public partial class frmFinalScore : Form
    {
        int userScore;

        public frmFinalScore()
        {
            InitializeComponent();

        }
        

        public int UserScore
        {
            get
            {
                return userScore;
            }
            set
            {
                userScore = value;
            }

        }

        private void frmFinalScore_Load(object sender, EventArgs e)
        {
            lblUserFinalScore.Text = userScore + "/10";
            if (userScore >= 8 && userScore < 10)
            {
                lblFinalScoreMessage.Text = "The force is strong with you young Jedi!!!";
            }
            else if(userScore < 8 && userScore >= 5)
            {
                lblFinalScoreMessage.Text = "The force is growing stronger with you!!";
            }
            else if (userScore < 5 && userScore >= 3)
            {
                lblFinalScoreMessage.Text = "Keep trying to master the force within!";
            }
            else
            {
                lblFinalScoreMessage.Text = "You must never give up.";
                lblSecondMessage.Text = "Unleash the force and try again!";         
            }
        }
    }
}
