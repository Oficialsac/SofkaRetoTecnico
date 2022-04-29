using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SofkaRetoTecnico.Clases;

namespace SofkaRetoTecnico.Forms
{
    public partial class frmGame : Form
    {
        QuestionsGeneration questionsGeneration = new QuestionsGeneration();
        Player player = new Player();   
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            
            initialGame();
        }

        void initialGame()
        {

            if(player.score == 0)
            {
                questionsGeneration.GetQuestions(1, lblQuest, btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4);
            }

        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            Validate VA = new Validate();
            VA.validateAnswer(lblQuest.Text, btnAnswer1.Text, lblScore, lblQuest, btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4, player);

        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            Validate VA = new Validate();
            VA.validateAnswer(lblQuest.Text, btnAnswer2.Text,lblScore, lblQuest,btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4, player);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            Validate VA = new Validate();
            VA.validateAnswer(lblQuest.Text, btnAnswer3.Text, lblScore, lblQuest, btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4, player);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            Validate VA = new Validate();
            VA.validateAnswer(lblQuest.Text, btnAnswer4.Text, lblScore, lblQuest, btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4, player);
        }
    }
}
