﻿namespace SistemaAdministrativo
{
    partial class FrmSisAd
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSisAd));
            this.PanelOpciones = new System.Windows.Forms.Panel();
            this.btnHojaSocial = new System.Windows.Forms.Button();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.btnEliModi = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnNotificacion = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            this.PanelOpciones.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelOpciones.BackgroundImage")));
            this.PanelOpciones.Controls.Add(this.btnHojaSocial);
            this.PanelOpciones.Controls.Add(this.btnEnviarMensaje);
            this.PanelOpciones.Controls.Add(this.btnEliModi);
            this.PanelOpciones.Controls.Add(this.btnDetalles);
            this.PanelOpciones.Controls.Add(this.btnInicio);
            this.PanelOpciones.Controls.Add(this.btnCerrarSesion);
            this.PanelOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelOpciones.Location = new System.Drawing.Point(0, 0);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Size = new System.Drawing.Size(232, 487);
            this.PanelOpciones.TabIndex = 2;
            // 
            // btnHojaSocial
            // 
            this.btnHojaSocial.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHojaSocial.Image = ((System.Drawing.Image)(resources.GetObject("btnHojaSocial.Image")));
            this.btnHojaSocial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHojaSocial.Location = new System.Drawing.Point(0, 328);
            this.btnHojaSocial.Name = "btnHojaSocial";
            this.btnHojaSocial.Size = new System.Drawing.Size(232, 48);
            this.btnHojaSocial.TabIndex = 13;
            this.btnHojaSocial.Text = "   Hoja de Hora Social";
            this.btnHojaSocial.UseVisualStyleBackColor = true;
            this.btnHojaSocial.Click += new System.EventHandler(this.btnHojaSocial_Click);
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMensaje.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarMensaje.Image")));
            this.btnEnviarMensaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnviarMensaje.Location = new System.Drawing.Point(0, 280);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(232, 48);
            this.btnEnviarMensaje.TabIndex = 12;
            this.btnEnviarMensaje.Text = "Enviar mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            // 
            // btnEliModi
            // 
            this.btnEliModi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliModi.Image = ((System.Drawing.Image)(resources.GetObject("btnEliModi.Image")));
            this.btnEliModi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliModi.Location = new System.Drawing.Point(0, 232);
            this.btnEliModi.Name = "btnEliModi";
            this.btnEliModi.Size = new System.Drawing.Size(232, 48);
            this.btnEliModi.TabIndex = 10;
            this.btnEliModi.Text = "Eliminar/Modificar";
            this.btnEliModi.UseVisualStyleBackColor = true;
            this.btnEliModi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalles.Image")));
            this.btnDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalles.Location = new System.Drawing.Point(0, 184);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(232, 48);
            this.btnDetalles.TabIndex = 9;
            this.btnDetalles.Text = "Detalles ";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 136);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(232, 48);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 440);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 47);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Tag = "Cerrar Sesión";
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.btnPerfil);
            this.PanelMenu.Controls.Add(this.btnNotificacion);
            this.PanelMenu.Controls.Add(this.pnlLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(232, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(658, 40);
            this.PanelMenu.TabIndex = 3;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfil.Image")));
            this.btnPerfil.Location = new System.Drawing.Point(585, 0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(72, 40);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificacion.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificacion.Image")));
            this.btnNotificacion.Location = new System.Drawing.Point(513, 0);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.Size = new System.Drawing.Size(75, 40);
            this.btnNotificacion.TabIndex = 3;
            this.btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(658, 40);
            this.pnlLogo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Menú Administrativo ";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pictBoxLogo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(232, 40);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(658, 447);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxLogo.Image")));
            this.pictBoxLogo.Location = new System.Drawing.Point(56, 160);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(579, 112);
            this.pictBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxLogo.TabIndex = 0;
            this.pictBoxLogo.TabStop = false;
            // 
            // FrmSisAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 487);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelOpciones);
            this.Location = new System.Drawing.Point(224, 40);
            this.Name = "FrmSisAd";
            this.Text = "5";
            this.PanelOpciones.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOpciones;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnNotificacion;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnHojaSocial;
        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.Button btnEliModi;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBoxLogo;
    }
}

