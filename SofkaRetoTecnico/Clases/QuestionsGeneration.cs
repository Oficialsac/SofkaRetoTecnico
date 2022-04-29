using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SofkaRetoTecnico.Clases;
using System.Data.SqlClient;
using System.Data;

namespace SofkaRetoTecnico.Clases
{
    
        
   class QuestionsGeneration
   {
        String str;
        dbConection conection;
        Random rand = new Random();
        setAnswers SA = new setAnswers();


        public void GetQuestions(int Category, System.Windows.Forms.Label lblQuest,System.Windows.Forms.Button btn1, System.Windows.Forms.Button btn2, System.Windows.Forms.Button btn3, System.Windows.Forms.Button btn4)
        {
           
            str = "Questions";
           
            conection = new dbConection();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(str,conection.OpenConection());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@category", Category);
            adapter.SelectCommand.ExecuteNonQuery();
            adapter.Fill(dt);

            if( dt.Rows.Count > 0)
            {
                lblQuest.Text = dt.Rows[rand.Next(0,4)][0].ToString();
                SA.SetAnswers(Category, lblQuest.Text, btn1, btn2, btn3, btn4);
            }

        }

        
    }

    
}
