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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        //Agegar Arreglos
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

                    for (int x = 0; x < tamaño; x++) 
                    {
                        nombres[x] = Interaction.InputBox("Escribe el nombre de la serie");
                        descripcion[x] = Interaction.InputBox("Escribe una descripcion sobre la serie");
                        capitulos[x] = Convert.ToInt32(Interaction.InputBox("Escribe la cantidad de capitulos de la serie"));
                    }

                    for (int x = 0; x < tamaño; x++)
                    {
                        lbNombres.Items.Add(nombres[x]);
                        lbDescripcion.Items.Add(descripcion[x]);
                        lbCapitulos.Items.Add(capitulos[x]);
                    }

                }
                 
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Borrar Arreglos
        private void EliminarArreglos()
        {
            nombres = new string[0];
            capitulos = new int[0];
            descripcion = new string[0];

            lbNombres.Items.Clear();
            lbDescripcion.Items.Clear();
            lbCapitulos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EliminarArreglos();
                MessageBox.Show("Arreglos borrados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Editar Arreglos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbNombres.SelectedIndex != -1) 
                {
                    int y = lbNombres.SelectedIndex;

                    string nombreActual = nombres[y];
                    string descripcionActual = descripcion[y];
                    int capitulosActual = capitulos[y];

                    string nuevoNombre = Interaction.InputBox("Edita el nombre de la serie", "Edición", nombreActual);
                    string nuevaDescripcion = Interaction.InputBox("Edita la descripción de la serie", "Edición", descripcionActual);
                    int nuevosCapitulos = Convert.ToInt32(Interaction.InputBox("Edita la cantidad de capítulos de la serie", "Edición", capitulosActual.ToString()));

                    nombres[y] = nuevoNombre;
                    descripcion[y] = nuevaDescripcion;
                    capitulos[y] = nuevosCapitulos;

                    lbNombres.Items[y] = nuevoNombre;
                    lbDescripcion.Items[y] = nuevaDescripcion;
                    lbCapitulos.Items[y] = nuevosCapitulos;
                }
                else
                {
                    MessageBox.Show("Selecciona un elemento para editar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ordenar por Capitulos
        private void OrdenarPorCapitulos()
        {
            for (int i = 0; i < tamaño - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < tamaño; j++)
                {
                    if (capitulos[j] < capitulos[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    int tempCapitulos = capitulos[i];
                    capitulos[i] = capitulos[minIndex];
                    capitulos[minIndex] = tempCapitulos;

                    string tempNombres = nombres[i];
                    nombres[i] = nombres[minIndex];
                    nombres[minIndex] = tempNombres;

                    string tempDescripcion = descripcion[i];
                    descripcion[i] = descripcion[minIndex];
                    descripcion[minIndex] = tempDescripcion;
                }
            }
        }

        private void ActualizarListas()
        {
      
            lbNombres.Items.Clear();
            lbDescripcion.Items.Clear();
            lbCapitulos.Items.Clear();

            for (int x = 0; x < tamaño; x++)
            {
                lbNombres.Items.Add(nombres[x]);
                lbDescripcion.Items.Add(descripcion[x]);
                lbCapitulos.Items.Add(capitulos[x]);
            }
        }

        private void btnOrdenarCapitulos_Click(object sender, EventArgs e)
        {
            try
            {
                if (capitulos != null && capitulos.Length > 1)
                {
                    OrdenarPorCapitulos();

                    ActualizarListas();
                }
                else
                {
                    MessageBox.Show("Asegúrate de haber ingresado los datos correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
