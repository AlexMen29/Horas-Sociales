using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class FrmSisAd : Form
    {
        public FrmSisAd()
        {
            InitializeComponent();
        }



        private void AbrirForm(object FrmInicio)
        {
            if(pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            Form fh = FrmInicio as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
             FrmDatosInicio us = new FrmDatosInicio();
             AbrirForm(us);

             pictBoxLogo.Visible = false;
        }
        
        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FrmDetallesAd us = new FrmDetallesAd();
            AbrirForm(us);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarDetallesAlum us = new EliminarDetallesAlum();
            AbrirForm(us);
        }
    }
}