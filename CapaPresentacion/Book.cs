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
    public partial class Book : Form
    {
        CN_Libros objetoCN_Libro = new CN_Libros();

        private string idLibro = null;
        private bool Editar = false;

        public Book()
        {
            InitializeComponent();
            MostrarLibros();
        }

        private void MostrarLibros()
        {
            CN_Libros objeto = new CN_Libros();
            dataGridView1.DataSource = objetoCN_Libro.MostrarLibro();
        }

        private void btn_guardarLibro_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN_Libro.InsertarLibro(txt_ejemplares.Text, txt_ISBN.Text, txt_titulo.Text, txt_autor.Text, txt_editorial.Text, txt_anioedicion.Text, txt_numedicion.Text, txt_pais.Text, txt_idioma.Text, txt_materia.Text, txt_paginas.Text, txt_ubicacion.Text, txt_descripcion.Text);
                    MessageBox.Show("El libro se inserto correctamente");
                    MostrarLibros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }

            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCN_Libro.EditarLibro(txt_ejemplares.Text, txt_ISBN.Text, txt_titulo.Text, txt_autor.Text, txt_editorial.Text, txt_anioedicion.Text, txt_numedicion.Text, txt_pais.Text, txt_idioma.Text, txt_materia.Text, txt_paginas.Text, txt_ubicacion.Text, txt_descripcion.Text, idLibro);
                    MessageBox.Show("se edito correctamente");
                    MostrarLibros();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btn_EditarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txt_ejemplares.Text = dataGridView1.CurrentRow.Cells["ejemplares"].Value.ToString();
                txt_ISBN.Text = dataGridView1.CurrentRow.Cells["ISBN"].Value.ToString();
                txt_titulo.Text = dataGridView1.CurrentRow.Cells["titulo"].Value.ToString();
                txt_autor.Text = dataGridView1.CurrentRow.Cells["autor"].Value.ToString();
                txt_editorial.Text = dataGridView1.CurrentRow.Cells["editorial"].Value.ToString();
                txt_anioedicion.Text = dataGridView1.CurrentRow.Cells["anioedicion"].Value.ToString();
                txt_numedicion.Text = dataGridView1.CurrentRow.Cells["numedicion"].Value.ToString();
                txt_pais.Text = dataGridView1.CurrentRow.Cells["pais"].Value.ToString();
                txt_idioma.Text = dataGridView1.CurrentRow.Cells["idioma"].Value.ToString();
                txt_materia.Text = dataGridView1.CurrentRow.Cells["materia"].Value.ToString();
                txt_paginas.Text = dataGridView1.CurrentRow.Cells["paginas"].Value.ToString();
                txt_ubicacion.Text = dataGridView1.CurrentRow.Cells["ubicacion"].Value.ToString();
                txt_descripcion.Text = dataGridView1.CurrentRow.Cells["descripcion"].Value.ToString();
                idLibro = dataGridView1.CurrentRow.Cells["codigolibro"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void limpiarForm()
        {
            txt_ejemplares.Clear();
            txt_ISBN.Clear();
            txt_titulo.Clear();
            txt_autor.Clear();
            txt_editorial.Clear();
            txt_anioedicion.Clear();
            txt_numedicion.Clear();
            txt_pais.Clear();
            txt_idioma.Clear();
            txt_materia.Clear();
            txt_paginas.Clear();
            txt_ubicacion.Clear();
            txt_descripcion.Clear();
        }

        private void btn_EliminarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idLibro = dataGridView1.CurrentRow.Cells["codigolibro"].Value.ToString();
                objetoCN_Libro.EliminarLibro(idLibro);
                MessageBox.Show("Eliminado correctamente");
                MostrarLibros();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
