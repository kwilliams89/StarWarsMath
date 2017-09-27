/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace KWilliams_CS3280_Assignment5
{
    public class Score
    {
        String name;
        int timeTaken;
        int wrongAnswers;
        int correctAnswers;

        /// <summary>
        /// Constructor builds Score object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="correct"></param>
        /// <param name="wrong"></param>
        /// <param name="time"></param>
        public Score(String name, int correct, int wrong, int time)
        {
            this.name = name;
            timeTaken = time;
            correctAnswers = correct;
            wrongAnswers = wrong;
        }

        public Score(Score newScore)
        {
            this.name = newScore.name;
            this.timeTaken = newScore.timeTaken;
            this.correctAnswers = newScore.correctAnswers;
            this.wrongAnswers = newScore.wrongAnswers;
        }
        /// <summary>
        /// Compares two score objects and return 1 if score1 is greater and 2 if score2 is greater
        /// </summary>
        /// <param name="score2"></param>
        /// <returns></returns>
        public int compareScores(Score score2)
        {
            try
            {
                if (score2.correctAnswers > this.correctAnswers)
                {
                    return 1; // returns code 1 if second score object has more correct answers
                }
                else if (score2.correctAnswers == this.correctAnswers)
                {
                    if (score2.timeTaken < this.timeTaken)
                    {
                        return 1; // returns code 1 if both score objects have the same amount of correct answers, but the second was done in less time.
                    }
                    else
                    {
                        return 2; // returns code 2 if the first score object was done in less time
                    }
                }
                else
                {
                    return 2; // returns code 2 if score1 has more correct answers
                }
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Overrides base ToString method to format output for Score objects
        /// </summary>
        /// <returns></returns>
        override public String ToString()
        {
            try
            {
                return name + " " + correctAnswers.ToString() + " " + wrongAnswers.ToString() + " " + timeTaken.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        #region Properties

        public String Name
        {
            get
            {
                return name;
            }
        }

        public int TimeTaken
        {
            get
            {
                return timeTaken;
            }
        }
        public int WrongAnswers
        {
            get
            {
                return wrongAnswers;
            }
        }
        public int CorrectAnswers
        {
            get
            {
                return correctAnswers;
            }
        }

        #endregion 
    }
}
*/