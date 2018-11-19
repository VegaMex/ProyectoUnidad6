using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.util {
    public class Conexion {
        public string GetConnectionString() {
            String servidor = "68.183.49.7";
            String puerto = "3306";
            String usuario = "anita";
            String password = "lagordalagartonanotragaladrogalatina";
            String database = "terpomo";
            return String.Format("Server={0};Database={4};Uid={2};Pwd={3};", servidor, puerto, usuario, password, database);
        }
        public void EjecutaSQLComando(MySqlCommand sqlCom) {
            MySqlConnection sqlConn = new MySqlConnection();
            try {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.ExecuteNonQuery();
            } finally {
                sqlConn.Close();
            }
        }
        public string EjecutaSQLScalar(string sComandoSql) {
            string regreso = "";
            MySqlConnection sqlConn = new MySqlConnection();
            MySqlCommand sqlCom = new MySqlCommand();
            try {
                sqlConn.ConnectionString = GetConnectionString();
                sqlConn.Open();
                sqlCom.Connection = sqlConn;
                sqlCom.CommandText = sComandoSql;
                regreso = sqlCom.ExecuteScalar().ToString();
            } finally {
                sqlConn.Close();
            }
            return regreso;
        }
        public DataSet LLenaComboGrid(string mysql) {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlConnection cnn = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            try {
                cnn.ConnectionString = GetConnectionString();
                cnn.Open();
                cmd.CommandText = mysql;
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = cnn;
                da.Fill(ds);
            } finally {
                cnn.Close();
            }
            return ds;
        }

    }

}