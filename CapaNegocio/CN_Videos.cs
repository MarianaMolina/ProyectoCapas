using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_Videos
    {
        private CD_Videos objetoCD_video = new CD_Videos();
        public DataTable MostrarVideo()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD_video.Mostrar();
            return tabla;
        }

        public void InsertarVideo(string titulo, string directora, string productora, string Tipo, string anio, string duracion, string pais, string idioma, string subtitulo, string clasificacion, string genero, string sinopsis, string ubicacion)
        {

            objetoCD_video.Insertar( titulo,  directora,  productora,  Tipo,  anio,  duracion,  pais,  idioma,  subtitulo,  clasificacion,  genero,  sinopsis,  ubicacion);
        }

        public void EditarVideo(string titulo, string directora, string productora, string Tipo, string anio, string duracion, string pais, string idioma, string subtitulo, string clasificacion, string genero, string sinopsis, string ubicacion, string id)
        {
            objetoCD_video.Editar(Convert.ToInt16(id),  titulo,  directora,  productora,  Tipo,  anio,  duracion,  pais,  idioma,  subtitulo,  clasificacion,  genero,  sinopsis,  ubicacion);
        }

        public void EliminarVideo(string id)
        {
            objetoCD_video.Eliminar(Convert.ToInt32(id));
        }
    }
}
