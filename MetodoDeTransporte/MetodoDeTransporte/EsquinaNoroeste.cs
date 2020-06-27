using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Globalization;

namespace MetodoDeTransporte
{
    class EsquinaNoroeste
    {
        private double resultado;
        private bool seguir;
        private DataGridView dgvTabla;

        private double[] ofertaActual;
        private double[] demandaActual;
        
        private double ofertaTotal = 0;
        private double demandaTotal = 0;
       
        private int esquinaColumna = 0;
        private int esquinaFila = 0;
        private int filas = 0;
        private int columnas =  0;

        private Datos[ , ] datos;
        public EsquinaNoroeste()
        {

        }

        public void calcularResultado(DataGridView tabla)
        {
            dgvTabla = tabla;
            ofertaTotal = totalOferta().Sum();
            demandaTotal = totalDemanda().Sum();

            filas = tabla.Rows.Count;
            columnas = tabla.Columns.Count;

            MessageBox.Show(filas.ToString());

            //obtengo los datos de la tabla y los ingresos al campo cantidad de los objetos datos
            obtenerDatosTabla();

            

            //if (ofertaTotal == demandaTotal)
            //{
            //    do
            //    {
            //        seguir = calcular(ofertaActual, demandaActual);

            //    } while (!seguir);
            //} else
            //{
            //    MessageBox.Show("La oferta y la demanda no esta balanceadas\nPor lo tanto no se puede realizar la operacion", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }

        private bool calcular(double[] oferta, double[] demanda)
        {
            ofertaActual = totalOferta();
            demandaActual = totalDemanda();

            if(esquinaColumna < columnas || esquinaFila < filas)
            {



                return false;
            }
            else
            {
                return true;
            }
            
        }

        private double[] totalOferta()
        {
            double[] oferta = new double[dgvTabla.Rows.Count];

            for (int i = 0; i < dgvTabla.Rows.Count; i++)
            {
                if (dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value != null)
                {
                   oferta[i] = double.Parse(dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value.ToString());
                }
            }

            return oferta;
        }

        private double[] totalDemanda()
        {
            double[] demanda = new double[dgvTabla.Columns.Count];

            for (int i = 1; i < dgvTabla.Columns.Count; i++)
            {
                if (dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value != null)
                {
                    demanda[i - 1] = double.Parse(dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value.ToString());
                }
            }


            return demanda;
        }

        //el metodo obtiene los datos de la tabla y los ingrese al campo cantidad de los objetos datos
        private void obtenerDatosTabla()
        {

            datos = new Datos[filas-2, columnas-1];
            int cont = 0;
            for(int i = 0; i < filas-2; i++)
            {
                for(int j = 1; j < columnas-1; j++)
                {
                    if (dgvTabla.Rows[i].Cells[j].Value != null)
                    {
                        cont++;
                        Console.WriteLine(cont);
                        datos[i, j].Cantidad = int.Parse(dgvTabla.Rows[i].Cells[j].Value.ToString());
                    }
                }
            }


        }
    }

}
