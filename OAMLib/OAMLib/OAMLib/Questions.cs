using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
   public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionTitle { get; set; }

        public Question()
        { }

        public int CreateQuestion()
        {
            return 0;
        }
        public int DeleteQuestion()
        {
            return 0;
        }

        public int UpdateQuestion()
        {
            return 0;
        }
        public static List<Question> GetAllQuestions()
        {
            return null;
        }


        public static Question GetQuestionByID(int QuestionID)
        {
            return null;
        }
    }
}
