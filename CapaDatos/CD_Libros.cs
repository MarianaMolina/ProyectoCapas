 using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Libros
    {
        private BD_Conexion conexion = new BD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarLibros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string ejemplares, string ISBN, string titulo, string autor, string editorial, int anioedicion, string numedicion , string pais, string idioma, string materia, string paginas, string ubicacion, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarLibro";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ejemplares", ejemplares);
            comando.Parameters.AddWithValue("@ISBN", ISBN);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@autor", autor);
            comando.Parameters.AddWithValue("@editorial", editorial);
            comando.Parameters.AddWithValue("@anioedicion", anioedicion);
            comando.Parameters.AddWithValue("@numedicion", numedicion);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@idioma", idioma);
            comando.Parameters.AddWithValue("@materia", materia);
            comando.Parameters.AddWithValue("@paginas", paginas);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Editar(int id,string ejemplares, string ISBN, string titulo, string autor, string editorial, int anioedicion, string numedicion, string pais, string idioma, string materia, string paginas, string ubicacion, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarLibro";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ejemplares", ejemplares);
            comando.Parameters.AddWithValue("@ISBN", ISBN);
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@autor", autor);
            comando.Parameters.AddWithValue("@editorial", editorial);
            comando.Parameters.AddWithValue("@anioedicion", anioedicion);
            comando.Parameters.AddWithValue("@numedicion", numedicion);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@idioma", idioma);
            comando.Parameters.AddWithValue("@materia", materia);
            comando.Parameters.AddWithValue("@paginas", paginas);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarLibro";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
