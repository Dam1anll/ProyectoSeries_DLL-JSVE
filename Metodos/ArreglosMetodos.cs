using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;
using ProyectoSeries_DLL_JSVE.Forms;

namespace ProyectoSeries_DLL_JSVE.Metodos
{
    public class ArreglosMetodos
    {
        private Serie[] series;
        private int tamaño;
        private TextBox txtTamaño; 
        private DataGridView GridArreglos;

        public ArreglosMetodos(TextBox txtTamaño, DataGridView gridArreglos)
        {
            this.txtTamaño = txtTamaño;
            this.GridArreglos = gridArreglos;
        }

        //Agregar Arreglos 
        public void AgregarArreglos()
        {
            try
            {
                if (txtTamaño.Text != null)
                {
                    tamaño = int.Parse(txtTamaño.Text);
                    int ultimaIdExistente = series != null && series.Length > 0 ? series.Max(s => s.id) : 0;

                    series = new Serie[tamaño];

                    for (int x = 0; x < tamaño; x++)
                    {
                        int id = ultimaIdExistente + x + 1;
                        string nombre = Interaction.InputBox("Escribe el nombre de la serie");
                        string descripcion = Interaction.InputBox("Escribe una descripción sobre la serie");
                        int nroCapitulos = Convert.ToInt32(Interaction.InputBox("Escribe la cantidad de capítulos de la serie"));

                        series[x] = new Serie(id, nombre, descripcion, nroCapitulos);
                    }

                    for (int x = 0; x < tamaño; x++)
                    {
                        GridArreglos.Rows.Add(series[x].id, series[x].nombre, series[x].descripcion, series[x].nroCapitulos);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Eliminar Arreglos
        public void EliminarArreglos()
        {
            try
            {
                if (tamaño > 0)
                {
                    int idEliminar = Convert.ToInt32(Interaction.InputBox("Ingrese el id del arreglo a eliminar"));

                    int indice = Array.FindIndex(series, serie => serie.id == idEliminar);

                    if (indice != -1)
                    {
                        Serie[] nuevaMatriz = new Serie[tamaño - 1];

                        for (int i = 0, j = 0; i < tamaño; i++)
                        {
                            if (i != indice)
                            {
                                nuevaMatriz[j] = series[i];
                                j++;
                            }
                        }

                        series = nuevaMatriz;
                        tamaño--;

                        ActualizarGrid();

                        MessageBox.Show("Arreglo eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("ID no encontrado. Ingrese un ID válido.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay arreglos para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarGrid()
        {
            GridArreglos.Rows.Clear();

            for (int x = 0; x < tamaño; x++)
            {
                GridArreglos.Rows.Add(series[x].id, series[x].nombre, series[x].descripcion, series[x].nroCapitulos);
            }
        }

        //Editar Arreglos
        public void EditarSerie()
        {
            try
            {
                int idSerieEditar = Convert.ToInt32(Interaction.InputBox("Ingrese el ID de la serie que desea editar:", "Edición", ""));

                Serie serieEditar = null;

                foreach (Serie s in series)
                {
                    if (s.id == idSerieEditar)
                    {
                        serieEditar = s;
                        break;
                    }
                }

                if (serieEditar != null)
                {
                    string nuevoNombre = Interaction.InputBox("Edita el nombre de la serie", "Edición", serieEditar.nombre);
                    string nuevaDescripcion = Interaction.InputBox("Edita la descripción de la serie", "Edición", serieEditar.descripcion);
                    int nuevosCapitulos = Convert.ToInt32(Interaction.InputBox("Edita la cantidad de capítulos de la serie", "Edición", serieEditar.nroCapitulos.ToString()));

                    serieEditar.nombre = nuevoNombre;
                    serieEditar.descripcion = nuevaDescripcion;
                    serieEditar.nroCapitulos = nuevosCapitulos;

                    foreach (DataGridViewRow row in GridArreglos.Rows)
                    {
                        if ((int)row.Cells["IdSerie"].Value == idSerieEditar)
                        {
                            row.Cells["NombreSerie"].Value = nuevoNombre;
                            row.Cells["DescripcionSerie"].Value = nuevaDescripcion;
                            row.Cells["NroCapitulosSerie"].Value = nuevosCapitulos;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar la serie con el ID proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Ordenar Arreglos
        public void OrdenarArreglo()
        {
            try
            {
                if (tamaño > 0)
                {
                    for (int i = 0; i < tamaño - 1; i++)
                    {
                        int indiceMinimo = i;

                        for (int j = i + 1; j < tamaño; j++)
                        {
                            if (series[j].nroCapitulos < series[indiceMinimo].nroCapitulos)
                            {
                                indiceMinimo = j;
                            }
                        }

                        Serie temp = series[i];
                        series[i] = series[indiceMinimo];
                        series[indiceMinimo] = temp;
                    }

                    ActualizarGrid();

                    MessageBox.Show("Arreglos ordenados");
                }
                else
                {
                    MessageBox.Show("No hay arreglos para ordenar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
