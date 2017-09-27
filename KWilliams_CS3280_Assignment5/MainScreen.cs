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
    public partial class MainScreen : Form
    {
        #region Attributes
        /// <summary>
        /// Class that holds user data
        /// </summary>
        frmUserLogin frmUserLoginForm;

        /// <summary>
        /// Class where the game is played
        /// </summary>
        frmGameScreen frmGameScreenForm;

        /// <summary>
        /// Class that holds the high scores
        /// </summary>
        frmFinalScore frmHighScoresForm;
        String myUser;

        #endregion

        #region Public Methods/Constructor

        /// <summary>
        /// Initializes Main Screen form.
        /// </summary>
        public MainScreen()
        {
            InitializeComponent();

            frmUserLoginForm = new frmUserLogin();
            frmGameScreenForm = new frmGameScreen();
            frmHighScoresForm = new frmFinalScore();
            pnlGameModes.Enabled = false;

            //         frmGameScreenForm.CopyHighScores = frmHighScoresForm;
        }

        #endregion

        #region Event Driven Methods

        /// <summary>
        /// Opens Login form so user can login before being allowed to play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmUserLoginForm.ShowDialog();
                pnlGameModes.Enabled = true;
                btnLogin.Enabled = false;
                myUser = frmUserLoginForm.CurrentUser;
                this.Show();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }


        /// <summary>
        /// Starts a new game of addition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmGameScreenForm.GameType = 0;
                frmGameScreenForm.CurrentUser = myUser;
                frmGameScreenForm.ShowDialog();
                btnLogin.Enabled = true;
                this.Show();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// Starts a new game of subtraction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmGameScreenForm.GameType = 1;
                frmGameScreenForm.CurrentUser = myUser;
                frmGameScreenForm.ShowDialog();
                btnLogin.Enabled = true;
                this.Show();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message); ;
            }
        }

        /// <summary>
        /// Starts a new game of multiplcation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmGameScreenForm.GameType = 2;
                frmGameScreenForm.CurrentUser = myUser;
                frmGameScreenForm.ShowDialog();
                btnLogin.Enabled = true;
                this.Show();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message); ;
            }
        }

        /// <summary>
        /// Starts a new game of division
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmGameScreenForm.GameType = 3;
                frmGameScreenForm.CurrentUser = myUser;
                frmGameScreenForm.ShowDialog();
                btnLogin.Enabled = true;
                this.Show();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        #endregion

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            frmHighScoresForm.ShowDialog();
        }

        public String CurrentUser
        {
            get
            {
                return myUser.ToString();
            }
        }
    }
}
