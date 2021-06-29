using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_Libros
    {
        private CD_Libros objetoCD_Libro = new CD_Libros();
        public DataTable MostrarLibro()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD_Libro.Mostrar();
            return tabla;
        }

        public void InsertarLibro(string ejemplares, string ISBN, string titulo, string autor, string editorial, string anioedicion, string numedicion, string pais, string idioma, string materia, string paginas, string ubicacion, string descripcion)
        {

            objetoCD_Libro.Insertar( ejemplares,  ISBN,  titulo,  autor,  editorial, Convert.ToInt16(anioedicion),  numedicion,  pais,  idioma,  materia,  paginas,  ubicacion,  descripcion);
        }

        public void EditarLibro(string ejemplares, string ISBN, string titulo, string autor, string editorial, string anioedicion, string numedicion, string pais, string idioma, string materia, string paginas, string ubicacion, string descripcion, string id)
        {
            objetoCD_Libro.Editar(Convert.ToInt16(id),ejemplares, ISBN, titulo, autor, editorial, Convert.ToInt16(anioedicion), numedicion, pais, idioma, materia, paginas, ubicacion, descripcion);
        }

        public void EliminarLibro(string id)
        {
            objetoCD_Libro.Eliminar(Convert.ToInt32(id));
        }
    }
}
