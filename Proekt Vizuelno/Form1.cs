using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_Vizuelno
{
    public partial class Form1 : Form { 


        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;


        public Form1()
    {
        InitializeComponent();

        askQuestion(questionNumber);

        totalQuestions = 22;
    }

    private void checkAnswerEvent(object sender, EventArgs e)
    {
        var senderObject = (Button)sender;

        int buttonTag = Convert.ToInt32(senderObject.Tag);

        if (buttonTag == correctAnswer)
        {
            score++;
        }

        if (questionNumber == totalQuestions)
        {
            // work out the percentage

            percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

            MessageBox.Show(
                "Квизот заврши!" + Environment.NewLine +
                "Одговоривте " + score + " точни прашања." + Environment.NewLine +
                "Процент на успешност " + percentage + "%" + Environment.NewLine +
                "Кликнете ОК за повторно"
                );

            score = 0;
            questionNumber = 0;
            askQuestion(questionNumber);

        }

        questionNumber++;
        askQuestion(questionNumber);

    }

    private void askQuestion(int qnum)
    {

        switch (qnum)
        {
            case 1:
                pictureBox1.Image = Properties.Resources.GJEVREK;


                button1.Text = "Розева";
                button2.Text = "Бела";
                button3.Text = "Ѓеврек";
                button4.Text = "Црвена";

                correctAnswer = 1;

                break;
            case 2:
                pictureBox1.Image = Properties.Resources.GJEVREK1;


                button1.Text = "Сина";
                button2.Text = "Хоби";
                button3.Text = "Ништо";
                button4.Text = "Ѓеврек";

                correctAnswer = 4;

                break;
            case 3:
                pictureBox1.Image = Properties.Resources.PORTOKALOVA;


                button1.Text = "Розева";
                button2.Text = "Портокалова";
                button3.Text = "Бела";
                button4.Text = "Сина";

                correctAnswer = 4;

                break;
            case 4:
                pictureBox1.Image = Properties.Resources.REBRO;


                button1.Text = "Црна";
                button2.Text = "Ребро";
                button3.Text = "Ништо";
                button4.Text = "Бела";

                correctAnswer = 3;

                break;

            case 5:
                pictureBox1.Image = Properties.Resources.REBRO1;


                button1.Text = "Ребро";
                button2.Text = "Сина";
                button3.Text = "Кафеава";
                button4.Text = "Ништо";

                correctAnswer = 1;

                break;

            case 6:
                pictureBox1.Image = Properties.Resources.ROLETNA;


                button1.Text = "Ролетна";
                button2.Text = "Сина";
                button3.Text = "Ништо";
                button4.Text = "Кафеава";

                correctAnswer = 3;

                break;

            case 7:
                pictureBox1.Image = Properties.Resources.KAFENA;


                button1.Text = "Сина";
                button2.Text = "Ништо";
                button3.Text = "Кафеава";
                button4.Text = "Бела";

                correctAnswer = 3;

                break;

            case 8:
                pictureBox1.Image = Properties.Resources.HOBI;


                button1.Text = "Бела";
                button2.Text = "Ништо";
                button3.Text = "Кафеава";
                button4.Text = "Жолта";

                correctAnswer = 4;

                break;

            case 9:
                pictureBox1.Image = Properties.Resources.HOBI1;


                button1.Text = "Ништо";
                button2.Text = "Жолта";
                button3.Text = "Хоби";
                button4.Text = "Бела";

                correctAnswer = 1;

                break;


            case 10:
                pictureBox1.Image = Properties.Resources.HOBI2;


                button1.Text = "Ништо";
                button2.Text = "Жолта";
                button3.Text = "Хоби";
                button4.Text = "Бела";

                correctAnswer = 3;

                break;


             case 11:
                    pictureBox1.Image = Properties.Resources.LAPTOP;


                    button1.Text = "Лаптоп";
                    button2.Text = "Жолта";
                    button3.Text = "Црвена";
                    button4.Text = "Сина";

                    correctAnswer = 1;

                    break;


             case 12:
                    pictureBox1.Image = Properties.Resources.MAJA;


                    button1.Text = "Ништо";
                    button2.Text = "Маса";
                    button3.Text = "Црвена";
                    button4.Text = "Портокалева";

                    correctAnswer = 2;

                    break;

             case 13:
                    pictureBox1.Image = Properties.Resources.PORTOKALOVA1;


                    button1.Text = "Ништо";
                    button2.Text = "Портокалева";
                    button3.Text = "Црна";
                    button4.Text = "Бела";

                    correctAnswer = 1;

                    break;


             case 14:
                    pictureBox1.Image = Properties.Resources.PORTOKALOVA2;


                    button1.Text = "Сина";
                    button2.Text = "Портокалова";
                    button3.Text = "Црвена";
                    button4.Text = "Бела";

                    correctAnswer = 3;

                    break;


             case 15:
                    pictureBox1.Image = Properties.Resources.ROLETNA1;


                    button1.Text = "Ролетна";
                    button2.Text = "Сина";
                    button3.Text = "Црвена";
                    button4.Text = "Бела";

                    correctAnswer = 1;

                    break;


             case 16:
                    pictureBox1.Image = Properties.Resources.ROZEVA;


                    button1.Text = "Црвена";
                    button2.Text = "Розева";
                    button3.Text = "Бела";
                    button4.Text = "Ништо";

                    correctAnswer = 1;

                    break;
             case 17:
                    pictureBox1.Image = Properties.Resources.ROZEVA1;


                    button1.Text = "Црвена";
                    button2.Text = "Розева";
                    button3.Text = "Жолта";
                    button4.Text = "Розева";

                    correctAnswer = 3;

                    break;
             case 18:
                    pictureBox1.Image = Properties.Resources.TELEFON;


                    button1.Text = "Црвена";
                    button2.Text = "Жолта";
                    button3.Text = "Зелена";
                    button4.Text = "Телефон";

                    correctAnswer = 4;

                    break;

              case 19:
                    pictureBox1.Image = Properties.Resources.ZELENA;


                    button1.Text = "Зелена";
                    button2.Text = "Жолта";
                    button3.Text = "Бела";
                    button4.Text = "Портокалева";

                    correctAnswer = 4;

                    break;
              case 20:
                    pictureBox1.Image = Properties.Resources.ZELENA1;


                    button1.Text = "Црвена";
                    button2.Text = "Зелена";
                    button3.Text = "Портокалева";
                    button4.Text = "Розева";

                    correctAnswer = 3;

                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.ZOLTA;


                    button1.Text = "Жолта";
                    button2.Text = "Зелена";
                    button3.Text = "Бела";
                    button4.Text = "Розева";

                    correctAnswer = 2;

                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.ZOLTA1;


                    button1.Text = "Жолта";
                    button2.Text = "Зелена";
                    button3.Text = "Бела";
                    button4.Text = "Сина";

                    correctAnswer = 4;

                    break;

            }



        }

}
}
