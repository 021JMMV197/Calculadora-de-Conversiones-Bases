using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

public class ConexionDB
{
    private readonly string connectionString;

    public ConexionDB()
    {
        connectionString = @"Server=localhost;Database=ConversorDB;User Id=sa;Password=sprt0912*;";
    }

    public SqlConnection ObtenerConexion()
    {
        return new SqlConnection(connectionString);
    }
}
