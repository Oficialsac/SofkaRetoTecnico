using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SofkaRetoTecnico.Forms;

namespace SofkaRetoTecnico.Clases
{
    class Validate
    {
        Answers ans = new Answers();
        QuestionsGeneration QG = new QuestionsGeneration(); 
        
        public void validateAnswer(String quest, String userAns, System.Windows.Forms.Label lblScore,System.Windows.Forms.Label lblQuest, System.Windows.Forms.Button btn1, System.Windows.Forms.Button btn2, System.Windows.Forms.Button btn3, System.Windows.Forms.Button btn4, Player player)
        {

            if (ans.getCorrectAnswer(quest).Equals(userAns)) {
                player.score = player.score + 20;

                if (player.score > 0 && player.score <=20)
                {
                    next(2, lblQuest, btn1, btn2, btn3, btn4);
                }
                else if(player.score > 20 && player.score <= 40)
                {
                    next(3, lblQuest, btn1, btn2, btn3, btn4);
                }else if (player.score > 40 && player.score <= 60)
                {
                    next(4, lblQuest, btn1, btn2, btn3, btn4);
                }
                else if (player.score > 60 && player.score <= 80)
                {
                    next(5, lblQuest, btn1, btn2, btn3, btn4);
                }

                if (player.score == 100)
                {
                    MessageBox.Show("Congrats you have 100 points, you WIN !!");
                    player.updateScore(player.name,player.score);
                }

                lblScore.Text = player.score.ToString();
                

            }
            else
            {
                MessageBox.Show("Sorry you lost");
                player.score = 0;
            }

        }

        public void next(int category,System.Windows.Forms.Label lblQuest, System.Windows.Forms.Button btn1, System.Windows.Forms.Button btn2, System.Windows.Forms.Button btn3, System.Windows.Forms.Button btn4)
        {
            QG.GetQuestions(category, lblQuest, btn1, btn2, btn3,btn4);

        }
    }
}
