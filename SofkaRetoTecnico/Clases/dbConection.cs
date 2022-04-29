using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SofkaRetoTecnico.Clases
{
    internal class dbConection
    {
        static private string strConection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\57313\Desktop\SofkaRetoTecnico\SofkaRetoTecnico\dbPreguntados.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection Conection = new SqlConnection(strConection);

        public SqlConnection OpenConection()
        {
            if (Conection.State == ConnectionState.Closed)
                Conection.Open();
            return Conection;
        }

        public SqlConnection ClosedConexion()
        {
            if (Conection.State == ConnectionState.Open)
                Conection.Close();
            return Conection;
        }
    }
}
