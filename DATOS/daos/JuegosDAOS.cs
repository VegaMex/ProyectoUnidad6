using DATOS.modelo;
using DATOS.util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DATOS.daos {
    public class JuegosDAOS {

        public void insert(JuegosModelo i) {

            Conexion con = new Conexion();

            String SQL = "INSERT INTO juegos (nombre, genero, fechalanzamiento, desarrollador, clasificacion, precio, rating, publicador, imagen)" +
                "VALUES (@nombre, @genero, @fechalanzamiento, @desarrollador, @clasificacion, @precio, @rating, @publicador, @imagen);";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@nombre", i.nombre);
            sqlCom.Parameters.AddWithValue("@genero", i.genero);
            sqlCom.Parameters.AddWithValue("@fechalanzamiento", i.fechalanzamiento);
            sqlCom.Parameters.AddWithValue("@desarrollador", i.desarrollador);
            sqlCom.Parameters.AddWithValue("@clasificacion", i.clasificacion);
            sqlCom.Parameters.AddWithValue("@precio", i.precio);
            sqlCom.Parameters.AddWithValue("@rating", i.rating);
            sqlCom.Parameters.AddWithValue("@publicador", i.publicador);
            sqlCom.Parameters.AddWithValue("@imagen", i.imagen);
            con.EjecutaSQLComando(sqlCom);

        }

        public void delete(int idjuego) {
            Conexion con = new Conexion();
            String SQL = "DELETE FROM juegos WHERE idjuego=@idjuego limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idjuego", idjuego);
            con.EjecutaSQLComando(sqlCom);
        }

        public void update(JuegosModelo i) {

            Conexion con = new Conexion();
            String SQL = "UPDATE juegos SET nombre = @nombre, genero = @genero, fechalanzamiento = @fechalanzamiento, desarrollador = @desarrollador, clasificacion = @clasificacion, precio = @precio, rating = @rating, publicador = @publicador, imagen = @imagen WHERE idjuego = @idjuego limit 1;";

            MySqlCommand sqlCom = new MySqlCommand();
            sqlCom.CommandText = SQL;
            sqlCom.Parameters.AddWithValue("@idjuego", i.idjuego);
            sqlCom.Parameters.AddWithValue("@nombre", i.nombre);
            sqlCom.Parameters.AddWithValue("@genero", i.genero);
            sqlCom.Parameters.AddWithValue("@fechalanzamiento", i.fechalanzamiento);
            sqlCom.Parameters.AddWithValue("@desarrollador", i.desarrollador);
            sqlCom.Parameters.AddWithValue("@clasificacion", i.clasificacion);
            sqlCom.Parameters.AddWithValue("@precio", i.precio);
            sqlCom.Parameters.AddWithValue("@rating", i.rating);
            sqlCom.Parameters.AddWithValue("@publicador", i.publicador);
            sqlCom.Parameters.AddWithValue("@imagen", i.imagen);
            con.EjecutaSQLComando(sqlCom);

        }

        public List<JuegosModelo> getAll() {
            List<JuegosModelo> lista = new List<JuegosModelo>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM juegos");
            DataTable dt = datos.Tables[0];
            JuegosModelo i;
            foreach (DataRow r in dt.Rows) {

                i = new JuegosModelo();

                i.idjuego = (int)r.ItemArray[0];
                i.nombre = (String)r.ItemArray[1];
                i.genero = (String)r.ItemArray[2];
                i.fechalanzamiento = (DateTime)r.ItemArray[3];
                i.desarrollador = (String)r.ItemArray[4];
                i.clasificacion = (String)r.ItemArray[5];
                i.precio = (decimal)r.ItemArray[6];
                i.rating = (decimal)r.ItemArray[7];
                i.publicador = (String)r.ItemArray[8];

                if (r.ItemArray[9] == System.DBNull.Value) {
                    i.imagen = null;
                } else {
                    i.imagen = (byte[])r.ItemArray[9];
                }

                lista.Add(i);
            }

            return lista;
        }

        public List<JuegosModelo> getFiltro(string develop) {
            List<JuegosModelo> lista = new List<JuegosModelo>();
            Conexion con = new Conexion();

            DataSet datos = con.LLenaComboGrid("SELECT * FROM juegos WHERE desarrollador='" + develop + "';");
            DataTable dt = datos.Tables[0];
            JuegosModelo i;
            foreach (DataRow r in dt.Rows) {

                i = new JuegosModelo();

                i.idjuego = (int)r.ItemArray[0];
                i.nombre = (String)r.ItemArray[1];
                i.genero = (String)r.ItemArray[2];
                i.fechalanzamiento = (DateTime)r.ItemArray[3];
                i.desarrollador = (String)r.ItemArray[4];
                i.clasificacion = (String)r.ItemArray[5];
                i.precio = (decimal)r.ItemArray[6];
                i.rating = (decimal)r.ItemArray[7];
                i.publicador = (String)r.ItemArray[8];

                if (r.ItemArray[9] == System.DBNull.Value) {
                    i.imagen = null;
                } else {
                    i.imagen = (byte[])r.ItemArray[9];
                }

                lista.Add(i);
            }

            return lista;
        }

        public JuegosModelo search(int idjuego) {
            int contador = 0;
            List<JuegosModelo> lista = new List<JuegosModelo>();
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM juegos WHERE idjuego=" + idjuego + ";");
            DataTable dt = datos.Tables[0];
            JuegosModelo i = null;
            foreach (DataRow r in dt.Rows) {
                i = new JuegosModelo();
                i.idjuego = (int)r.ItemArray[0];
                i.nombre = (String)r.ItemArray[1];
                i.genero = (String)r.ItemArray[2];
                i.fechalanzamiento = (DateTime)r.ItemArray[3];
                i.desarrollador = (String)r.ItemArray[4];
                i.clasificacion = (String)r.ItemArray[5];
                i.precio = (decimal)r.ItemArray[6];
                i.rating = (decimal)r.ItemArray[7];
                i.publicador = (String)r.ItemArray[8];

                if (r.ItemArray[9] == System.DBNull.Value) {
                    i.imagen = null;
                } else {
                    i.imagen = (byte[])r.ItemArray[9];
                }

                lista.Add(i);
                contador++;
            }
            if (contador == 1) {
                return i;
            } else {
                return i = null;
            }
        }

        public DataSet getAllDataset() {
            Conexion con = new Conexion();
            DataSet datos = con.LLenaComboGrid("SELECT * FROM juegos");
            return datos;
        }
    }
}
