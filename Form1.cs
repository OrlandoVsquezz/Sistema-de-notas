using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_de_romedios
{
    public partial class fmrCalculoPromedios : Form
    {
        public fmrCalculoPromedios()
        {
            InitializeComponent();
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
                Close();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            double notaUno, notaDos, notaTres, promedio;
            if (string.IsNullOrEmpty(txtNota1.Text) || string.IsNullOrEmpty(txtNota2.Text) || string.IsNullOrEmpty(txtNota3.Text))
            {
                lblError.Text = "Existe un campo vacio, por favor, ingresa el dato que falta";
            } 
            else
            {
                notaUno = double.Parse(txtNota1.Text);
                notaDos = double.Parse(txtNota2.Text);
                notaTres = double.Parse(txtNota3.Text);

                if ((notaUno > 10 || notaUno < 0)||(notaDos > 10 || notaDos < 0)||(notaTres > 10 || notaTres < 0))
                {
                    lblError.Text = "Por favor ingresa un valor entre 1 y 10";
                }
                else
                {
                    promedio = (notaUno + notaDos + notaTres) / 3;
                    txtPromedio.Text = promedio.ToString("N2");
                    lblError.Text = string.Empty;
                    txtNota1.ReadOnly = true;
                    txtNota2.ReadOnly = true;
                    txtNota3.ReadOnly = true;
                }
            }
        }


    }
}
