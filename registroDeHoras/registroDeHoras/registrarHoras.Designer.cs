namespace registroDeHoras
{
    partial class registrarHoras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarHoras));
            panel1 = new Panel();
            panel2 = new Panel();
            txtRegistrar = new Label();
            panel3 = new Panel();
            boxHoras = new ComboBox();
            label3 = new Label();
            txtActividad = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtRegistrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(325, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // txtRegistrar
            // 
            txtRegistrar.AllowDrop = true;
            txtRegistrar.Anchor = AnchorStyles.None;
            txtRegistrar.AutoSize = true;
            txtRegistrar.BackColor = SystemColors.ButtonHighlight;
            txtRegistrar.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRegistrar.Location = new Point(55, 178);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.Size = new Size(221, 76);
            txtRegistrar.TabIndex = 0;
            txtRegistrar.Text = "Registrar Horas \r\nSociales";
            txtRegistrar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(boxHoras);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtActividad);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(314, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(487, 450);
            panel3.TabIndex = 1;
            // 
            // boxHoras
            // 
            boxHoras.Anchor = AnchorStyles.None;
            boxHoras.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            boxHoras.FormattingEnabled = true;
            boxHoras.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            boxHoras.Location = new Point(224, 368);
            boxHoras.Name = "boxHoras";
            boxHoras.Size = new Size(47, 23);
            boxHoras.TabIndex = 5;
            boxHoras.SelectedIndexChanged += boxHoras_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(105, 333);
            label3.Name = "label3";
            label3.Size = new Size(288, 32);
            label3.TabIndex = 4;
            label3.Text = "Total de horas Realizadas:";
            // 
            // txtActividad
            // 
            txtActividad.Anchor = AnchorStyles.None;
            txtActividad.Location = new Point(84, 269);
            txtActividad.Name = "txtActividad";
            txtActividad.Size = new Size(333, 23);
            txtActividad.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(144, 222);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 2;
            label2.Text = "Actividad Realizada:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Location = new Point(135, 44);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(212, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // registrarHoras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "registrarHoras";
            Text = "Registrar Horas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtRegistrar;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtActividad;
        private ComboBox boxHoras;
        private Label label3;
    }
}