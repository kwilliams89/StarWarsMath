using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace KWilliams_CS3280_Assignment5
{
    class Game
    {
        #region Attributes

        int[] number1;  //stores first number of each problem
        int[] number2;    //stores second number of each problem
        int[] userAnswer; //stores user answer for each problem
        int[] correctAnswer;  //stores correct answer for each problem
        int finalscore; //stores user's final score 
        int currentQuestion; //stores current question index
        private Random rndQ1; // used to generate random questions

        #endregion

        #region Public Methods

        /// <summary>
        /// Constructor initializes needed arrays and generates questions/answers based on gametype. 
        /// </summary>
        /// <param name="gametype"></param>
        public Game(int gametype)
        {
            number1 = new int[10];
            number2 = new int[10];
            userAnswer = new int[10];
            correctAnswer = new int[10];
            finalscore = 0;
            currentQuestion = 0;
            rndQ1 = new Random();

            if (gametype == 2)
            {
                generateMultQuestions();
                generateAnswers(gametype);
            }
            else if (gametype == 3)
            {
                generateDivQuestions();
                generateAnswers(gametype);
            }
            else
            {
                generateMathQuestions();
                generateAnswers(gametype);
            }
        }

        /// <summary>
        /// Grades user's answers and generates final score. 
        /// </summary>
        public Boolean checkAnswer()
        {
            try
            {
                if (userAnswer[currentQuestion] == correctAnswer[currentQuestion])
                {
                    finalscore++;
                    return true; 
                }
                else
                {
                    return false; 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Top level method that is called to handle exceptions. Implemented as demonstrated in Exception Handling lecture video.
        /// </summary>
        /// <param name="sClass"></param>
        /// <param name="sMethod"></param>
        /// <param name="sMessage"></param>
        public static void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message); //
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Generates random numbers for questions in multiplication game modes
        /// </summary>
        private void generateMultQuestions()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    number1[i] = rndQ1.Next(1, 13);
                    number2[i] = number1[i];

                    while (number1[i] == number2[i])
                    {
                        number2[i] = rndQ1.Next(1, 13);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Generates random numbers for questions in division game modes
        /// </summary>
        private void generateDivQuestions()
        {
            try
            {
                int test1;
                int test2;

                for (int i = 0; i < 10; i++)         //loops through each index in the number arrrays
                {
                    while (number1[i] == 0 || number2[i] == 0)          //test to keep looping until preferred values are obtained
                    {
                        test1 = rndQ1.Next(1, 21);
                        test2 = test1;

                        while (test1 == test2)
                        {
                            test2 = rndQ1.Next(2, 21);
                        }

                        if (test1 % test2 == 0)                          //test generated numbers for whole division
                        {
                            number1[i] = test1;
                            number2[i] = test2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Generates rand numbers for questions in addition/subtraction game modes
        /// </summary>
        private void generateMathQuestions()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    number1[i] = rndQ1.Next(1, 51);
                    number2[i] = number1[i];
                    while (number1[i] == number2[i])
                    {
                        number2[i] = rndQ1.Next(1, 51);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Generates correct answers and fills correctAnswers array with index corresponding to question number
        /// </summary>
        /// <param name="gametype"></param>
        private void generateAnswers(int gametype)
        {
            try
            {
                if (gametype == 0)
                {
                    for (int i = 0; i < 10; i++)     // calculates answers for addition problems
                    {
                        correctAnswer[i] = number1[i] + number2[i];

                    }
                }
                else if (gametype == 1)
                {
                    for (int i = 0; i < 10; i++)        //calculates answers for subtraction problems
                    {
                        correctAnswer[i] = number1[i] - number2[i];

                    }
                }
                else if (gametype == 2)                      // calculates answers for multiplcation problems
                {
                    for (int i = 0; i < 10; i++)
                    {
                        correctAnswer[i] = number1[i] * number2[i];

                    }
                }
                else               //calculates answers for division problems
                {
                    for (int i = 0; i < 10; i++)
                    {
                        correctAnswer[i] = number1[i] / number2[i];

                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #endregion

        #region Properties

        public int UserAnswer          // declare userAnswer property for setting user answer variable
        {
            set
            {
                userAnswer[currentQuestion] = value;
            }
        }

        public int CurrentQuestion      // declare CurrentQuestion property for setting current question index.
        {
            get
            {
                return currentQuestion;
            }
            set
            {
                currentQuestion = value;
            }
        }

        public int FinalScore      // declare FinalScore property for getting user's final score.
        {
            get
            {
                return finalscore;
            }
        }

        public int Number1      // declare Number1 property for getting first number used in math question.
        {
            get
            {
                return number1[currentQuestion];
            }
        }

        public int Number2      // declare Number2 property for getting second number used in math question.
        {
            get
            {
                return number2[currentQuestion];
            }
        }

        #endregion 
    }
}