using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace ProyectoSeries_DLL_JSVE.Forms
{
    public partial class FormArreglos : Form
    {
        public FormArreglos()
        {
            InitializeComponent();
        }

        string[] nombres;
        int[] capitulos;
        string[] descripcion;
        int tamaño;

        private void btnIngresarArreglos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTamaño.Text.Trim() != "") 
                {
                    tamaño = int.Parse(txtTamaño.Text.Trim());
                    nombres = new string[tamaño];
                    capitulos = new int[tamaño];
                    descripcion = new string[tamaño];

                    for(int x = 0; x < tamaño; x++) 
                    {
                        nombres[x] = Interaction.InputBox("Escribe el nombre de la serie");
                        descripcion[x] = Interaction.InputBox("Escribe una descripcion sobre la serie");
                        capitulos[x] = Convert.ToInt32(Interaction.InputBox("Escribe la cantidad de capitulos de la serie"));
                    }
                }
                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarArreglos_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < tamaño; x++)
            {
                lbNombres.Items.Add(nombres[x]);
                lbDescripcion.Items.Add(descripcion[x]);
                lbCapitulos.Items.Add(capitulos[x]);
            }
        }
    }
}
