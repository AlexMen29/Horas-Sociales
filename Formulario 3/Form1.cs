using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_3
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void btnRetroceder_MouseHover(object sender, EventArgs e) //Desde aquí, creo eventos para los botones, 
        {                                                                 //en este caso colores. 
            this.btnRetroceder.BackColor = Color.White;
        }

        private void btnRetroceder_MouseLeave(object sender, EventArgs e)
        {
            this.btnRetroceder.BackColor = Color.Red;
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            //Cambiaré el color a rojo:
            btnRetroceder.BackColor = Color.Red;
        }

        private void btnSiguienteFrm3_Click(object sender, EventArgs e)
        {
            this.btnSiguienteFrm3.BackColor = Color.Red;
        }

        private void btnSiguienteFrm3_MouseHover(object sender, EventArgs e)
        {
            this.btnSiguienteFrm3.BackColor = Color.White;
        }

        private void btnSiguienteFrm3_MouseLeave(object sender, EventArgs e)
        {
            this.btnSiguienteFrm3.BackColor = Color.Red;
        }

        private void txtBoxActividad_TextChanged(object sender, EventArgs e)
        {
            lblActi.Text = txtBoxActividad.Text; //Así se captura el texto en los TEXTBOX

        }

        private void txtBoxObjetivos_TextChanged(object sender, EventArgs e)
        {
            lblObje.Text = txtBoxObjetivos.Text;
        }

        private void txtBoxMetas_TextChanged(object sender, EventArgs e)
        {
            lblMetas.Text = txtBoxMetas.Text;
        }

        private void txtBoxDuracion_TextChanged(object sender, EventArgs e)
        {
            lblDuracion.Text = txtBoxDuracion.Text;
        }

        private void txtBoxLuAm_TextChanged(object sender, EventArgs e)
        {
            lblLunes.Text = txtBoxLuAm.Text;
        }

        private void txtBoxLuPm_TextChanged(object sender, EventArgs e)
        {
            lblLunes.Text = txtBoxLuPm.Text;
        }

        private void txtBoxMarAm_TextChanged(object sender, EventArgs e)
        {
            lblMartes.Text = txtBoxMarAm.Text;
        }

        private void txtBoxMarPm_TextChanged(object sender, EventArgs e)
        {
            lblMartes.Text = txtBoxMarPm.Text;
        }

        private void txtBoxMierAm_TextChanged(object sender, EventArgs e)
        {
            lblMiercoles.Text = txtBoxMierAm.Text;
        }

        private void txtBoxMierPm_TextChanged(object sender, EventArgs e)
        {
            lblMiercoles.Text = txtBoxMierPm.Text; 
        }

        private void txtBoxJueAm_TextChanged(object sender, EventArgs e)
        {
            lblJueves.Text = txtBoxJueAm.Text;
        }

        private void txtBoxJuePm_TextChanged(object sender, EventArgs e)
        {
            lblJueves.Text = txtBoxJuePm.Text;
        }

        private void txtBoxVierAm_TextChanged(object sender, EventArgs e)
        {
            lblViernes.Text = txtBoxVierAm.Text;
        }

        private void txtBoxVierPm_TextChanged(object sender, EventArgs e)
        {
            lblViernes.Text = txtBoxVierPm.Text;
        }

        private void txtBoxSabAm_TextChanged(object sender, EventArgs e)
        {
            lblSabado.Text = txtBoxSabAm.Text;
        }

        private void txtBoxSabPm_TextChanged(object sender, EventArgs e)
        {
            lblSabado.Text = txtBoxSabPm.Text;
        }

        private void txtBoxDomiAm_TextChanged(object sender, EventArgs e)
        {
            lblDomingo.Text = txtBoxDomiAm.Text;
        }

        private void txtBoxDomiPm_TextChanged(object sender, EventArgs e)
        {
            lblDomingo.Text = txtBoxDomiPm.Text;
        }
    }
}
