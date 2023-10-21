using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAdministrativo
{
    public partial class ImpresionDatos : Form
    {
        public ImpresionDatos()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.ImprimirContenido);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void ImprimirContenido(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial", 12);
            e.Graphics.DrawString("Este es un ejemplo de impresión.", fuente, Brushes.Black, 100, 100);
        }
    }
}
