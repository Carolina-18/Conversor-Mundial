using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        Conversores objconversor = new Conversores();
   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbmoneda.Items.AddRange(objconversor.etiquetas[0]);
            cmbcambiar.Items.AddRange(objconversor.etiquetas[0]);
            cmbdelongitud.Items.AddRange(objconversor.etiquetas[1]);
            cmbalongitud.Items.AddRange(objconversor.etiquetas[1]);
            cmbdepeso.Items.AddRange(objconversor.etiquetas[2]);
            cmbapeso.Items.AddRange(objconversor.etiquetas[2]);
            cmbdevolumen.Items.AddRange(objconversor.etiquetas[3]);
            cmbavolumen.Items.AddRange(objconversor.etiquetas[3]);
            cmbdealmacenamiento.Items.AddRange(objconversor.etiquetas[4]);
            cmbaalmacenamiento.Items.AddRange(objconversor.etiquetas[4]);

        }

       
        private void btnconvertirL_Click(object sender, EventArgs e)
        {
           lblrespuestaL.Text = objconversor.convertir(cmbdelongitud.SelectedIndex, cmbalongitud.SelectedIndex,
                double.Parse(txtcantidadL.Text), 1).ToString();

        }

        private void btnconvertirM_Click(object sender, EventArgs e)
        {
               lblrespuestaM.Text = objconversor.convertir(cmbmoneda.SelectedIndex, cmbcambiar.SelectedIndex,
               double.Parse(txtcantidadM.Text), 0).ToString();
        
        
    }
        private void btnconvertirP_Click(object sender, EventArgs e)
        {
            lblrespuestaP.Text = objconversor.convertir(cmbdepeso.SelectedIndex, cmbapeso .SelectedIndex,
                double.Parse(txtcantidadP.Text), 2).ToString();
        }

        private void btnconvertirV_Click(object sender, EventArgs e)
        {
            lblrespuestaV.Text = objconversor.convertir(cmbdevolumen.SelectedIndex, cmbavolumen.SelectedIndex,
               double.Parse(txtcantidadV.Text), 3).ToString();
        }

        private void btnconvertirA_Click(object sender, EventArgs e)
        {
            lblrespuestaA.Text = objconversor.convertir(cmbdealmacenamiento.SelectedIndex, cmbaalmacenamiento.SelectedIndex,
              double.Parse(txtcantidadA.Text), 4).ToString();
        }
    }

           

        }

    
































// private void btnconvertirA_Click(object sender, EventArgs e)
//   {
// lblrespuestaA.Text = objconversor.convertir(cmbdealmacenamiento.SelectedIndex, cmbaalmacenamiento.SelectedIndex,
//  double.Parse(txtcantidadA.Text), 1).ToString();


//   }

//  private void btnconvertirV_Click(object sender, EventArgs e)
//{
//   lblrespuestaV.Text = objconversor.convertir(cmbdevolumen.SelectedIndex, cmbavolumen.SelectedIndex,
//  double.Parse(txtcantidadV.Text), 3).ToString();
// }

//  private void btnconvertirP_Click(object sender, EventArgs e)
//{
//    // lblrespuestaP.Text = objconversor.convertir(cmbdepeso.SelectedIndex, cmbapeso.SelectedIndex,
//  double.Parse(txtcantidadP.Text), 3).ToString();
//   }
//
//  private void tabPage2_Click(object sender, EventArgs e)
//  {

//   }
// }
// }



