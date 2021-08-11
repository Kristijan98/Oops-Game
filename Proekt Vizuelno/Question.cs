using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt_Vizuelno
{
    public class Question
    {
        public Image image { get; set; }
        public String answer1 { get; set; }
        public String answer2 { get; set; }
        public String answer3 { get; set; }
        public String answer4 { get; set; }
        public int correctAnswer { get; set; }

    }
}
