using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KWilliams_CS3280_Assignment5
{
    class User
    {
        #region Attributes

        String firstName;
        String lastName;
        int age;
        int finalScore;

        #endregion

        #region Private Methods
        /// <summary>
        /// Constructor initializes needed arrays and generates questions/answers based on gametype. 
        /// </summary>
        /// 
        public User()
        {
            firstName = "";
            lastName = "";
            age = 0;
            finalScore = 0;
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        #endregion

        #region Properties

        public String FirstName          //declare first name property for getting/setting user first name variable
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public String LastName          // declare last name property for getting/setting user last name variable
        {
            get
            {
                return firstName;
            }
            set
            {
                lastName = value;
            }
        }

        public int Age          // declare age property for getting/setting user age variable
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int FinalScore          // declare FinalScore property for setting user's final score for later use in tracking high scores
        {
            set
            {
                finalScore = value;
            }
        }

        #endregion 
    }
}
