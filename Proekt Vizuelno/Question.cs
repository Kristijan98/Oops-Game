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

        public Question(Image image,
            String answer1,
            String answer2,
            String answer3,
            String answer4,
            int correctAnswer)
        {
            this.image = image;
            this.answer1 = answer1;
            this.answer2 = answer2;
            this.answer3 = answer3;
            this.answer4 = answer4;
            this.correctAnswer = correctAnswer;
        }

        public Question ()
        {

        }
        

    }
}
