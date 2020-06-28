using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoDeTransporte
{
    class CostoMinimo
    {
        private double resultado;
        private bool seguir;
        private DataGridView dgvTabla;

        private double[] ofertaArray;
        private double[] demandaArray;

        private double ofertaTotal = 0;
        private double demandaTotal = 0;

        private int columnaMenor = 0;
        private int filaMenor = 0;

        private Datos[,] datos;

        public CostoMinimo()
        {

        }

        public double calcularResultado(DataGridView tabla)
        {
            dgvTabla = tabla;
            ofertaTotal = totalOferta().Sum();
            demandaTotal = totalDemanda().Sum();

            if ((ofertaTotal == demandaTotal) && ofertaTotal != 0 && demandaTotal != 0)
            {
                columnaMenor = 0;
                filaMenor = 0;

                //obtengo las ofertas y demandas de la tabla de forma indiviual
                ofertaArray = totalOferta();
                demandaArray = totalDemanda();

                MessageBox.Show(ofertaArray.Length + "x" + demandaArray.Length);

                //obtengo los datos de la tabla y los ingresos al campo cantidad de los objetos datos
                obtenerDatosTabla();

                do
                {
                    seguir = calcular();

                } while (!seguir);

                resultado = resultadoFinal();

                return resultado;

            }
            else
            {
                MessageBox.Show("La oferta y la demanda no esta balanceadas o son igual a 0\nPor lo tanto no se puede realizar la operacion", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }

        }

        private bool calcular()
        {
            busquedaCostoMenor();
            if (filaMenor >= 0 && columnaMenor >= 0)
            {
                double ofertaActual = ofertaArray[filaMenor];
                double demandaActual = demandaArray[columnaMenor];

                if (ofertaActual == demandaActual)
                {
                    datos[filaMenor, columnaMenor].Precio = demandaActual;
                    datos[filaMenor, columnaMenor].Llena = true;
                    demandaArray[columnaMenor] = 0;
                    ofertaArray[filaMenor] = 0;
                }

                else if (demandaActual > ofertaActual)
                {
                    demandaActual -= ofertaActual;
                    datos[filaMenor, columnaMenor].Precio = demandaActual;
                    datos[filaMenor, columnaMenor].Llena = true;

                    demandaArray[columnaMenor] = demandaActual;
                    ofertaArray[filaMenor] = 0;
                }

                else if (ofertaActual > demandaActual)
                {
                    ofertaActual -= demandaActual;
                    datos[filaMenor, columnaMenor].Precio = ofertaActual;
                    datos[filaMenor, columnaMenor].Llena = true;

                    ofertaArray[filaMenor] = ofertaActual;
                    demandaArray[columnaMenor] = 0;
                }

                return false;
            }
            else
            {
                return true;
            }

        }

        private double resultadoFinal()
        {
            double totalCosto = 0;

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    if (datos[i, j].Llena)
                    {
                        totalCosto += (datos[i, j].Cantidad * datos[i, j].Precio);
                    }
                }
            }

            return totalCosto;
        }

        private void busquedaCostoMenor()
        {
            filaMenor = -1;
            columnaMenor = -1;
            double precio, temporal = Double.MaxValue;

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {
                    if (datos[i, j].Cantidad != 0)
                    {
                        precio = datos[i, j].Cantidad;
                        if (temporal > precio && !datos[i, j].Llena)
                        {
                            filaMenor = i;
                            columnaMenor = j;
                            temporal = precio;
                        }
                    }
                }

            }
        }

        private double[] totalOferta()
        {
            double[] oferta = new double[dgvTabla.Rows.Count - 2];

            for (int i = 0; i < oferta.Length; i++)
            {
                if (dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value != null)
                {
                    oferta[i] = Convert.ToDouble(dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value.ToString());
                }
            }

            return oferta;
        }

        private double[] totalDemanda()
        {
            double[] demanda = new double[dgvTabla.Columns.Count - 2];

            for (int i = 1; i < dgvTabla.Columns.Count - 1; i++)
            {
                if (dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value != null)
                {
                    demanda[i - 1] = Convert.ToDouble(dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value.ToString());
                }
            }


            return demanda;
        }

        //el metodo obtiene los datos de la tabla y los ingrese al campo cantidad de los objetos datos
        private void obtenerDatosTabla()
        {
            datos = new Datos[dgvTabla.Rows.Count - 2, dgvTabla.Columns.Count - 2];
            MessageBox.Show(datos.GetLength(0) + "-" + datos.GetLength(1));

            for (int i = 0; i < datos.GetLength(0); i++)
            {
                for (int j = 0; j < datos.GetLength(1); j++)
                {

                    datos[i, j] = new Datos();
                    datos[i, j].Cantidad = Convert.ToDouble(dgvTabla.Rows[i].Cells[j + 1].Value.ToString());
                }
            }
            MessageBox.Show("Fin");

        }

    }
}
