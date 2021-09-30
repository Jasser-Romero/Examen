using Domain;
using Domain.Enums;
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
    public partial class FrmAgregarActivo : Form
    {
        public ActivoModel ActivoModel { get; set; }
        public FrmAgregarActivo()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ActivosFijos activosFijos = new ActivosFijos()
            {
                Id = ActivoModel.GetLastActivoId() + 1,
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                ValorActivo = nudValor.Value,
                FechaAdquisicion = dtpFechaAdq.Value,
                TipoActivo = (TipoActivo)cmbTipoActivo.SelectedIndex
            };

            ActivoModel.Add(activosFijos);

            Close();
        }


    }
}
