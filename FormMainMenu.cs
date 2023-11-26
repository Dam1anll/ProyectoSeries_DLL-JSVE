using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ProyectoSeries_DLL_JSVE.Forms;
using System.Windows.Forms;

namespace ProyectoSeries_DLL_JSVE
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu() 
        {
            InitializeComponent();
        }
        private void btnArreglos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormArreglos());
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormListas());
        }

        private void btnPilas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormPilas());
        }

        private void btnColas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormColas());
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel= false;
            fh.Dock= DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
