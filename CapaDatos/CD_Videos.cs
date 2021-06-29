using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Videos
    {
        private BD_Conexion conexion = new BD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVideos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string titulo, string directora, string productora, string Tipo, string anio, string duracion, string pais, string idioma, string subtitulo, string clasificacion,string genero, string sinopsis, string ubicacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVideo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@directora", directora);
            comando.Parameters.AddWithValue("@productora", productora);
            comando.Parameters.AddWithValue("@Tipo", Tipo);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@duracion", duracion);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@idioma", idioma);
            comando.Parameters.AddWithValue("@subtitulo", subtitulo);
            comando.Parameters.AddWithValue("@clasificacion", clasificacion);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@sinopsis", sinopsis);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Editar(int id, string titulo, string directora, string productora, string Tipo, string anio, string duracion, string pais, string idioma, string subtitulo, string clasificacion, string genero, string sinopsis, string ubicacion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVideo";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@directora", directora);
            comando.Parameters.AddWithValue("@productora", productora);
            comando.Parameters.AddWithValue("@Tipo", Tipo);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@duracion", duracion);
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@idioma", idioma);
            comando.Parameters.AddWithValue("@subtitulo", subtitulo);
            comando.Parameters.AddWithValue("@clasificacion", clasificacion);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@sinopsis", sinopsis);
            comando.Parameters.AddWithValue("@ubicacion", ubicacion);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVideo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
