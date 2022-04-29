using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SofkaRetoTecnico.Clases;
using SofkaRetoTecnico.Forms;

namespace SofkaRetoTecnico.Forms
{
    public partial class frmLoginPlayer : Form
    {
        
        Player players = new Player();
        public frmLoginPlayer()
        {
            InitializeComponent();
            
        }

        private void frmLoginPlayer_Load(object sender, EventArgs e)
        {

        }
        
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            players.name = txtUsername.Text;
            players.createPlayer(txtUsername.Text);
            frmGame startGame = new frmGame();
            startGame.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
