namespace GenteFitApp.Vistas
{
    partial class frmActividades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBMostrar = new System.Windows.Forms.ComboBox();
            this.pBSalas = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbVMonitor = new System.Windows.Forms.TextBox();
            this.tbVDescrip = new System.Windows.Forms.TextBox();
            this.tbVNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cBMonitor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBEliminar
            // 
            this.cBEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBEliminar.DisplayMember = "nombre";
            this.cBEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBEliminar.FormattingEnabled = true;
            this.cBEliminar.Location = new System.Drawing.Point(798, 405);
            this.cBEliminar.Name = "cBEliminar";
            this.cBEliminar.Size = new System.Drawing.Size(121, 29);
            this.cBEliminar.TabIndex = 47;
            this.cBEliminar.ValueMember = "id_Actividad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(798, 537);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 35);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(798, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 45;
            this.label10.Text = "Actividad";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(793, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "Eliminar Actividad:";
            // 
            // cBMostrar
            // 
            this.cBMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBMostrar.DisplayMember = "nombre";
            this.cBMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBMostrar.FormattingEnabled = true;
            this.cBMostrar.Location = new System.Drawing.Point(455, 86);
            this.cBMostrar.Name = "cBMostrar";
            this.cBMostrar.Size = new System.Drawing.Size(121, 29);
            this.cBMostrar.TabIndex = 43;
            this.cBMostrar.ValueMember = "id_Actividad";
            this.cBMostrar.Click += new System.EventHandler(this.cBMostrar_Click);
            // 
            // pBSalas
            // 
            this.pBSalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBSalas.Image = global::GenteFitApp.Properties.Resources.actividades;
            this.pBSalas.Location = new System.Drawing.Point(781, 64);
            this.pBSalas.Name = "pBSalas";
            this.pBSalas.Size = new System.Drawing.Size(174, 103);
            this.pBSalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalas.TabIndex = 42;
            this.pBSalas.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalir.Location = new System.Drawing.Point(99, 651);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 40);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCrear.Location = new System.Drawing.Point(562, 537);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(87, 35);
            this.btnCrear.TabIndex = 40;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nueva Actividad:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tbVMonitor);
            this.panel1.Controls.Add(this.tbVDescrip);
            this.panel1.Controls.Add(this.tbVNombre);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(437, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 189);
            this.panel1.TabIndex = 34;
            // 
            // tbVMonitor
            // 
            this.tbVMonitor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVMonitor.Location = new System.Drawing.Point(125, 152);
            this.tbVMonitor.Name = "tbVMonitor";
            this.tbVMonitor.Size = new System.Drawing.Size(159, 29);
            this.tbVMonitor.TabIndex = 6;
            // 
            // tbVDescrip
            // 
            this.tbVDescrip.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVDescrip.Location = new System.Drawing.Point(125, 61);
            this.tbVDescrip.Multiline = true;
            this.tbVDescrip.Name = "tbVDescrip";
            this.tbVDescrip.Size = new System.Drawing.Size(159, 78);
            this.tbVDescrip.TabIndex = 5;
            // 
            // tbVNombre
            // 
            this.tbVNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVNombre.Location = new System.Drawing.Point(125, 18);
            this.tbVNombre.Name = "tbVNombre";
            this.tbVNombre.Size = new System.Drawing.Size(159, 29);
            this.tbVNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(14, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Monitor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMostrar.Location = new System.Drawing.Point(624, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(97, 35);
            this.btnMostrar.TabIndex = 33;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Actividad";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDescripcion.Location = new System.Drawing.Point(562, 405);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(159, 66);
            this.tbDescripcion.TabIndex = 52;
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbNombre.Location = new System.Drawing.Point(562, 362);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(159, 29);
            this.tbNombre.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(451, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Monitor:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label11.Location = new System.Drawing.Point(451, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label12.Location = new System.Drawing.Point(451, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 48;
            this.label12.Text = "Nombre:";
            // 
            // cBMonitor
            // 
            this.cBMonitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBMonitor.DisplayMember = "nombre";
            this.cBMonitor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBMonitor.FormattingEnabled = true;
            this.cBMonitor.Location = new System.Drawing.Point(562, 489);
            this.cBMonitor.Name = "cBMonitor";
            this.cBMonitor.Size = new System.Drawing.Size(159, 29);
            this.cBMonitor.TabIndex = 53;
            this.cBMonitor.ValueMember = "id_Persona";
            this.cBMonitor.Click += new System.EventHandler(this.cBMonitor_Click);
            // 
            // frmActividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.cBMonitor);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cBEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBMostrar);
            this.Controls.Add(this.pBSalas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmActividades";
            this.Text = "frmActividades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pBSalas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBMostrar;
        private System.Windows.Forms.PictureBox pBSalas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbVMonitor;
        private System.Windows.Forms.TextBox tbVDescrip;
        private System.Windows.Forms.TextBox tbVNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBMonitor;
    }
}