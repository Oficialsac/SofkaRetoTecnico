using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace SofkaRetoTecnico.Clases
{
    
    class Player
    {
        private string strSting;
        dbConection conection = new dbConection();
        SqlDataAdapter adapter;
        public string name { get; set; }
        public int score { get; set; }

        public void createPlayer(String username)
        {
            
            Console.Write(username);
            strSting = "createPlayer";
            adapter = new SqlDataAdapter(strSting, conection.OpenConection());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@playerName", username);
            adapter.SelectCommand.ExecuteNonQuery();
            conection.ClosedConexion();

            name = username;
        }

        public void updateScore(String name,int score)
        {
            strSting = "UpdateScore";
            //adapter = new SqlDataAdapter(strSting, conection.OpenConection());
            //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adapter.SelectCommand.Parameters.AddWithValue("@name",name);
            //adapter.SelectCommand.Parameters.AddWithValue("@scored",score);
            //adapter.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Scored update");
            MessageBox.Show(this.name);
            MessageBox.Show(score.ToString());
            conection.ClosedConexion();
        }
    }
}
