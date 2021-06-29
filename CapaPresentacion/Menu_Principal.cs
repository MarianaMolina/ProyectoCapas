using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            Form Formulario = new Consulta();
            Formulario.Show();
        }

        private void btn_MantenimientoLibro_Click(object sender, EventArgs e)
        {
            Form Formulario = new Book();
            Formulario.Show();
        }

        private void btn_MantenimientoVideo_Click(object sender, EventArgs e)
        {
            Form Formulario = new Video();
            Formulario.Show();
        }

        private void btn_PrestamoLibro_Click(object sender, EventArgs e)
        {
            Form Formulario = new Prestamo_Libro();
            Formulario.Show();
        }

        private void btn_PrestamoVideo_Click(object sender, EventArgs e)
        {
            Form Formulario = new Prestamo_Video();
            Formulario.Show();
        }
    }
}
