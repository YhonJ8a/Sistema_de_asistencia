using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_asistencias.Vista
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelRegistros.Visible = true;
            panelPaginados.Visible = false;
            panelCargos.Visible = false;
            panelRegistros.Dock = DockStyle.Fill;
            btnAgregar.Visible = true; 
            btnGuardarCambio.Visible = false;


        }

 
    }
}
