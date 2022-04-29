using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SofkaRetoTecnico.Clases
{
    class Answers
    {

        private string strSting;
        dbConection conection = new dbConection();
        DataTable dt;
        SqlDataAdapter adapter;
       

        public String getCorrectAnswer(String question)
        {
            strSting = "correctAnswer";
            dt = new DataTable();
            adapter = new SqlDataAdapter(strSting, conection.OpenConection());
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@quest", question);
            adapter.SelectCommand.ExecuteNonQuery();

            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
                return dt.Rows[0][0].ToString();

            return "";
        }
    }
}
