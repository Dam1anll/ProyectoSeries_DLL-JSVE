using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;

namespace ProyectoSeries_DLL_JSVE.Forms
{
    public partial class FormListas : Form
    {
        private Nodo cabezaLista;
        public FormListas()
        {
            InitializeComponent();
            cabezaLista = null;
        }

        //Agregar Lista
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = new Serie(nombre, descripcion, nroCapitulos);
                if (AgregarASerie(nuevaSerie))
                {
                    MostrarListas();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error al agregar la serie.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para el número de capítulos.");
            }
        }

        private bool AgregarASerie(Serie nuevaSerie)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(nuevaSerie);
                nuevoNodo.siguiente = cabezaLista;
                cabezaLista = nuevoNodo;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la serie: {ex.Message}");
                return false;
            }
        }

        private void MostrarListas()
        {
            GridListas.Rows.Clear();

            Nodo nodoActual = cabezaLista;
            while (nodoActual != null)
            {
                Serie serieActual = nodoActual.datos;
                GridListas.Rows.Add(serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
                nodoActual = nodoActual.siguiente;
            }
        }

        private void LimpiarTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNroCapitulos.Text = string.Empty;
        }
    } 
}
