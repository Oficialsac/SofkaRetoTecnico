using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SofkaRetoTecnico.Clases
{
    public class setAnswers
    {
        Answers ANS = new Answers();
        public ArrayList RandomAns()
        {
            ArrayList ArrayWords = new ArrayList();
            ArrayWords.Add("344432");
            ArrayWords.Add("234444");
            ArrayWords.Add("539392");
            ArrayWords.Add("6 legs");
            ArrayWords.Add("4 legs");
            ArrayWords.Add("5 legs");
            ArrayWords.Add("3 months");
            ArrayWords.Add("2 months");
            ArrayWords.Add("3 months");
            ArrayWords.Add("Earth");
            ArrayWords.Add("Neptune");
            ArrayWords.Add("Jupiter");
            ArrayWords.Add("Alemania");
            ArrayWords.Add("Colombia");
            ArrayWords.Add("France Aisne");
            ArrayWords.Add("J");
            ArrayWords.Add("P");
            ArrayWords.Add("F");
            ArrayWords.Add("3 apples");
            ArrayWords.Add("1 apple");
            ArrayWords.Add("5 apples");
            ArrayWords.Add("Tiger");
            ArrayWords.Add("Spider");
            ArrayWords.Add("Dog");
            ArrayWords.Add("Iron");
            ArrayWords.Add("Feathers");
            ArrayWords.Add("None");
            ArrayWords.Add("Monday");
            ArrayWords.Add("Sunday");
            ArrayWords.Add("Tuersday");
            ArrayWords.Add("Black");
            ArrayWords.Add("White");
            ArrayWords.Add("Blue");
            ArrayWords.Add("11");
            ArrayWords.Add("3");
            ArrayWords.Add("6");
            ArrayWords.Add("A murder");
            ArrayWords.Add("Any");
            ArrayWords.Add("A car");
            ArrayWords.Add("In the nose");
            ArrayWords.Add("On the foot");
            ArrayWords.Add("In the ear");
            ArrayWords.Add("40 km");
            ArrayWords.Add("30 km/h");
            ArrayWords.Add("60 jm/h");
            ArrayWords.Add("Juan ll");
            ArrayWords.Add("Daniel XV");
            ArrayWords.Add("Jorge VI");
            ArrayWords.Add("October");
            ArrayWords.Add("December");
            ArrayWords.Add("July");
            ArrayWords.Add("For the canaries");
            ArrayWords.Add("Fot the birds");
            ArrayWords.Add("For parrots");
            ArrayWords.Add("A lighter");
            ArrayWords.Add("A match");
            ArrayWords.Add("A candle");
            ArrayWords.Add("In the middle");
            ArrayWords.Add("Aside");
            ArrayWords.Add("Behind");
            ArrayWords.Add("This is how the creator of language wanted it");
            ArrayWords.Add("Because if");
            ArrayWords.Add("The reason is not known");
            ArrayWords.Add("A car");
            ArrayWords.Add("A top");
            ArrayWords.Add("A pirinola");
            ArrayWords.Add("The end");
            ArrayWords.Add("The new start");
            ArrayWords.Add("The end of the road");
            ArrayWords.Add("A computer");
            ArrayWords.Add("A jump");
            ArrayWords.Add("One friend");
            ArrayWords.Add("One pair");
            ArrayWords.Add("Transparency");
            ArrayWords.Add("The matter");
            ArrayWords.Add("The vacuum");
            ArrayWords.Add("F");
            return ArrayWords;
        }

        public void SetAnswers(int category,String question,System.Windows.Forms.Button btn1, System.Windows.Forms.Button btn2, System.Windows.Forms.Button btn3,System.Windows.Forms.Button btn4)
        {
            ArrayList IAnswer = RandomAns();
            Random rand = new Random();
            switch (category)
            {
                case 1:
                    btn1.Text = IAnswer[rand.Next(0,IAnswer.Count)].ToString();
                    btn2.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn3.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn4.Text = ANS.getCorrectAnswer(question);
                    break;
                case 2:
                    btn1.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn2.Text = ANS.getCorrectAnswer(question);
                    btn3.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn4.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    break;
                case 3:
                    btn1.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn2.Text = ANS.getCorrectAnswer(question);
                    btn3.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn4.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    break;
                case 4:
                    btn1.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn2.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn3.Text = ANS.getCorrectAnswer(question);
                    btn4.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    break;
                case 5:
                    btn1.Text = ANS.getCorrectAnswer(question);
                    btn2.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn3.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    btn4.Text = IAnswer[rand.Next(0, IAnswer.Count)].ToString();
                    break;
            }
            

        }
    }
}
