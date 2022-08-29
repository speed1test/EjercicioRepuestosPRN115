using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2Refuerzo2UES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRepuestos_Click(object sender, EventArgs e)
        {
            bool estado = true;
            String[] descripcion = new String[100000000];
            double manoDeObra = 0;
            double[] precioRepuesto = new double[100000000];
            double sumatoriaRepuestos = 0;
            double montoTotal = 0;
            int contador = 0;
            int fin = 2;
            string listaRepuestos = String.Empty;

            do 
            {
                descripcion[contador] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una descripción: ");
                precioRepuesto[contador] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el valor del repuesto: "));
                fin = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Desea ingresar más datos? \n 1. Si \n 2. No  "));
                if (fin == 2) 
                {
                    estado = false;
                }
                contador++;

            }
            while (estado);
            manoDeObra = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese $ de mano obra:  "));
            for (int i = 0; i < contador; i++) 
            {
                sumatoriaRepuestos += precioRepuesto[i];
                listaRepuestos += "Nombre del repuesto: "+descripcion[i]+ " \n"+ "Precio de repuesto: " + precioRepuesto[i] + "\n";
            }
            montoTotal = (sumatoriaRepuestos + manoDeObra) * 0.13 + (sumatoriaRepuestos + manoDeObra);
            MessageBox.Show(listaRepuestos+ "\n"+"Monto total a pagar: "+montoTotal);
        }
    }
}
