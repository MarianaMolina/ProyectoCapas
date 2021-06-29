using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Consulta : Form
    {
        CN_Libros objetoCN_Libro = new CN_Libros();
        CN_Videos objetoCN_Video = new CN_Videos();
        public Consulta()
        {
            InitializeComponent();
            MostrarLibros();
            MostrarVideos();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void MostrarLibros()
        {
            dataGridView1.DataSource = objetoCN_Libro.MostrarLibro();
        }

        private void MostrarVideos()
        {
            dataGridView2.DataSource = objetoCN_Video.MostrarVideo();
        }

    }

}
