using Calculadora_de_conversiones_de_Bases.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace Calculadora_de_conversiones_de_Bases.Data
{
    public class ConversionRepository
    {
        private string connectionString = "Server=localhost;Database=ConversorDB;User Id=sa;Password=sprt0912*;";

        public void GuardarConversion(Conversion conversion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_GuardarConversion", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeroEntrada", conversion.NumeroEntrada);
                    cmd.Parameters.AddWithValue("@BaseOrigen", conversion.BaseOrigen);
                    cmd.Parameters.AddWithValue("@BaseDestino", conversion.BaseDestino);
                    cmd.Parameters.AddWithValue("@Resultado", conversion.Resultado);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
