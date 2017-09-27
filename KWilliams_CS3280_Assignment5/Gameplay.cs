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
    public partial class frmGameScreen : Form
    {
        #region Attributes

        Game myGame;
        int gametype;
        Timer myTimer;
        int myStopwatch;
        frmFinalScore frmFinalScoreForm;
        String myUser;

        #endregion

        #region Public Methods
        public frmGameScreen()
        {
            InitializeComponent();
            frmFinalScoreForm = new frmFinalScore();
            myTimer = new Timer();
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(MyTimer_Tick);
            myStopwatch = 0;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = myStopwatch.ToString();
            myStopwatch++;
        }

        #endregion

        #region Private Methods

        private String mathSymbol(int gametype)
        {
            try
            {
                if (gametype == 0)
                {
                    return "+";
                }
                else if (gametype == 1)
                {
                    return "-";
                }
                else if (gametype == 2)
                {
                    return "*";
                }
                else
                {
                    return "/";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        private void SubmitAnswer()
        {
            try
            {
                myGame.UserAnswer = Convert.ToInt32(txtUserAnswer.Text);

                if (myGame.checkAnswer())
                {
                    lblOutcome.Text = "That's correct :)";
                }
                else
                {
                    lblOutcome.Text = "Sorry, that's incorrect :(";
                }
                myGame.CurrentQuestion++;
                txtUserAnswer.Clear();
                if (myGame.CurrentQuestion != 10)
                {
                    lblQuestionNum.Text = "Question #" + (myGame.CurrentQuestion + 1).ToString();
                    lblMathQuestion.Text = myGame.Number1.ToString() + " " + mathSymbol(this.gametype) + " " + myGame.Number2.ToString() + " =";
                }
                else
                {
                    myTimer.Stop();
                    this.Hide();
                    frmFinalScoreForm.UserScore = myGame.FinalScore;
                    frmFinalScoreForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #endregion

        #region Event Driven Methods

        private void frmGameScreen_Load(object sender, EventArgs e)
        {
            myGame = new Game(this.gametype);
            lblQuestionNum.Text = "Question #" + (myGame.CurrentQuestion + 1).ToString();
            lblMathQuestion.Text = myGame.Number1.ToString() + " " + mathSymbol(this.gametype) + " " + myGame.Number2.ToString() + " =";
            txtUserAnswer.Enabled = false;
        }

        /// <summary>
        /// Handles behavior for submitting user guess when select button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitAnswer();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }

        }

        /// <summary>
        /// Starts the game and the timer. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                txtUserAnswer.Enabled = true;
                myTimer.Start();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Handles text input for user guess. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)8))
            {
                if (e.KeyChar == (char)13)
                {
                    SubmitAnswer();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Closes game form and gives focus back to main screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        #region Properties

        public int GameType         //declares GameType property for getting/setting gametype variable
        {
            get
            {
                return gametype;
            }
            set
            {
                gametype = value;
            }
        }


        public String CurrentUser
        {
            get
            {
                return myUser;
            }
            set
            {
                myUser = value;
            }

        }

        #endregion
    }
}
