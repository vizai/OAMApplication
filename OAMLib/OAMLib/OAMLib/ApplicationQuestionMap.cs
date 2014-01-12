using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dlabs.OAMLib
{
    public class ApplicationQuestionMap
    {
        public int AppQuestionMapID { get; set; }
        public int ApplicationID { get; set; }
        public int QuestionID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}
