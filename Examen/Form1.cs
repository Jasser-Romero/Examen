using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        private ActivosFijos activosFijos;
        private ActivoModel activoModel;
        public Form1()
        {
            activosFijos = new ActivosFijos();
            activoModel = new ActivoModel();
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarActivo frmAgregarActivo = new FrmAgregarActivo();
            frmAgregarActivo.ActivoModel = activoModel;
            frmAgregarActivo.ShowDialog();

            rtbImprimir.Text = activoModel.Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rtbImprimir.Text = "Id         Codigo       Nombre       Valor         Fecha Adquisicion       Tipo Activo";
        }
    }
}
