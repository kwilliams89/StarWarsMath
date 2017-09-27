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
    public partial class frmUserLogin : Form
    {
        User myUser;
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitLogin();
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }
        /// <summary>
        /// Retrieves user age from textbox and verifies input is an integer value. Idea adapted from answer on stackoverflow from T.Rob. Link to answer - http://stackoverflow.com/a/8199613
        /// </summary>

        private void txtUserAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)8))
                {
                    if (e.KeyChar == (char)13)
                    {
                        SubmitLogin();
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Game.HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name, MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void SubmitLogin()
        {
            try
            {
                if (txtFirstName.Text == "" || txtLastName.Text == "" || txtUserAge.Text == "")
                {
                    MessageBox.Show("Invalid Entry. Please enter your full name and age in order to play.", "Invalid/Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myUser = new User();
                    myUser.FirstName = txtFirstName.Text;
                    myUser.LastName = txtLastName.Text;
                    myUser.Age = Convert.ToInt32(txtUserAge.Text);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #region Properties

        public String CurrentUser
        {
            get
            {
                return myUser.ToString();
            }
        }

        #endregion 
    }
}
