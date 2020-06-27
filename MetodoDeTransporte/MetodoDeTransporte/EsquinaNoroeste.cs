using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoDeTransporte
{
    class EsquinaNoroeste
    {
        private double resultado;
        private bool seguir;
        private double ofertaActual;
        private double demandaActual;
        private double ofertaTotal = 0;
        private double demandaTotal = 0;
        private DataGridView dgvTabla;

        public EsquinaNoroeste()
        {

        }

        public void calcularResultado(DataGridView tabla)
        {
            dgvTabla = tabla;
            ofertaTotal = totalOferta();
            demandaTotal = totalDemanda();

            if (ofertaTotal == demandaTotal)
            {
                do
                {
                    seguir = calcular(ofertaActual, demandaActual);

                } while (!seguir);
            } else
            {
                MessageBox.Show("La oferta y la demanda no esta balanceadas\nPor lo tanto no se puede realizar la operacion", "Ërror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool calcular(double oferta, double demanda)
        {
            

            return false;
        }

        private double totalOferta()
        {
            double totalOferta = 0;

            for (int i = 0; i < dgvTabla.Rows.Count; i++)
            {
                if (dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value != null)
                {
                    totalOferta += double.Parse(dgvTabla.Rows[i].Cells[dgvTabla.Columns.Count - 1].Value.ToString());
                }
            }

            return totalOferta;
        }

        private double totalDemanda()
        {
            double totalDemanda = 0;

            for (int i = 1; i < dgvTabla.Columns.Count; i++)
            {
                if (dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value != null)
                { 
                    totalDemanda += double.Parse(dgvTabla.Rows[dgvTabla.Rows.Count - 2].Cells[i].Value.ToString());
                }
            }


            return totalDemanda;
        }
    }

}
