using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var bounds = Screen.FromControl(this).Bounds;
            //this.Width = bounds.Width - 650;
            //this.Height = bounds.Height - 350;

        }



        private void label1_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Black;
        }



   
        private void btnIngresar_MouseLeave(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = ColorTranslator.FromHtml("#b1201f");
            this.btnIngresar.ForeColor = Color.White;
        }

        private void btnIngresar_MouseEnter(object sender, EventArgs e)
        {
            this.btnIngresar.BackColor = ColorTranslator.FromHtml("#cd9013");
            this.btnIngresar.ForeColor = Color.White;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabRecuperarContraseña_MouseEnter(object sender, EventArgs e)
        {
            this.LabRecuperarContraseña.ForeColor = Color.Red;

        }

        private void LabRecuperarContraseña_MouseLeave(object sender, EventArgs e)
        {
            this.LabRecuperarContraseña.ForeColor = ColorTranslator.FromHtml("176; 25; 30");
        }


        private void labRegistrarme_MouseEnter_1(object sender, EventArgs e)
        {
            this.labRegistrarme.ForeColor = Color.Red;


        }

        private void labRegistrarme_MouseLeave(object sender, EventArgs e)
        {
            this.labRegistrarme.ForeColor = ColorTranslator.FromHtml("176; 25; 30");
        }

    


        private void PicOcultar_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {

                txtPassword.UseSystemPasswordChar = false; // Mostrar contraseña
                PicMostrar.Visible = true;
                PicOcultar.Visible = false;
            }


        }

        private void PicMostrar_Click(object sender, EventArgs e)
        {
        

            if (!txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = true;
                PicOcultar.Visible = true;
                PicMostrar.Visible = false;

            }

        }

        private void labRegistrarme_Click(object sender, EventArgs e)
        {
            EstudianteOrDocente frm = new EstudianteOrDocente();
           frm.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
