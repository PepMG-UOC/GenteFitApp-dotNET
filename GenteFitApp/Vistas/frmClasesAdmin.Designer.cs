namespace GenteFitApp.Vistas
{
    partial class frmClasesAdmin
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
            this.cBSala = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cBActividad = new System.Windows.Forms.ComboBox();
            this.pBClases = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.dGVClases = new System.Windows.Forms.DataGridView();
            this.cBHora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSalaDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClases)).BeginInit();
            this.SuspendLayout();
            // 
            // cBSala
            // 
            this.cBSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBSala.DisplayMember = "id_Sala";
            this.cBSala.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBSala.FormattingEnabled = true;
            this.cBSala.Location = new System.Drawing.Point(597, 380);
            this.cBSala.Name = "cBSala";
            this.cBSala.Size = new System.Drawing.Size(121, 29);
            this.cBSala.TabIndex = 47;
            this.cBSala.ValueMember = "id_Sala";
            this.cBSala.SelectedIndexChanged += new System.EventHandler(this.cBSala_SelectedIndexChanged);
            this.cBSala.Click += new System.EventHandler(this.cBSala_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnEliminar.Location = new System.Drawing.Point(897, 202);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 35);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cBActividad
            // 
            this.cBActividad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBActividad.DisplayMember = "id_Sala";
            this.cBActividad.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBActividad.FormattingEnabled = true;
            this.cBActividad.Location = new System.Drawing.Point(597, 335);
            this.cBActividad.Name = "cBActividad";
            this.cBActividad.Size = new System.Drawing.Size(121, 29);
            this.cBActividad.TabIndex = 43;
            this.cBActividad.ValueMember = "id_Sala";
            this.cBActividad.Click += new System.EventHandler(this.cBActividad_Click);
            // 
            // pBClases
            // 
            this.pBClases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBClases.Image = global::GenteFitApp.Properties.Resources.clases;
            this.pBClases.Location = new System.Drawing.Point(206, 52);
            this.pBClases.Name = "pBClases";
            this.pBClases.Size = new System.Drawing.Size(204, 135);
            this.pBClases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBClases.TabIndex = 42;
            this.pBClases.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalir.Location = new System.Drawing.Point(102, 649);
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
            this.btnCrear.Location = new System.Drawing.Point(631, 489);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(87, 35);
            this.btnCrear.TabIndex = 40;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Nueva Clase:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(459, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Clases Dia:";
            // 
            // tbDia
            // 
            this.tbDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDia.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDia.Location = new System.Drawing.Point(579, 61);
            this.tbDia.Name = "tbDia";
            this.tbDia.ReadOnly = true;
            this.tbDia.Size = new System.Drawing.Size(121, 29);
            this.tbDia.TabIndex = 7;
            // 
            // dGVClases
            // 
            this.dGVClases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClases.Location = new System.Drawing.Point(481, 110);
            this.dGVClases.MultiSelect = false;
            this.dGVClases.Name = "dGVClases";
            this.dGVClases.ReadOnly = true;
            this.dGVClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVClases.Size = new System.Drawing.Size(374, 127);
            this.dGVClases.TabIndex = 48;
            this.dGVClases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClases_CellClick);
            // 
            // cBHora
            // 
            this.cBHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cBHora.DisplayMember = "id_Sala";
            this.cBHora.DropDownHeight = 150;
            this.cBHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cBHora.FormattingEnabled = true;
            this.cBHora.IntegralHeight = false;
            this.cBHora.ItemHeight = 21;
            this.cBHora.Location = new System.Drawing.Point(597, 424);
            this.cBHora.MaxDropDownItems = 5;
            this.cBHora.Name = "cBHora";
            this.cBHora.Size = new System.Drawing.Size(121, 29);
            this.cBHora.TabIndex = 49;
            this.cBHora.ValueMember = "id_Sala";
            this.cBHora.Click += new System.EventHandler(this.cBHora_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label8.Location = new System.Drawing.Point(477, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Actividad:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(477, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Sala:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(477, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "Hora:";
            // 
            // tbSalaDetails
            // 
            this.tbSalaDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSalaDetails.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbSalaDetails.Location = new System.Drawing.Point(724, 380);
            this.tbSalaDetails.Name = "tbSalaDetails";
            this.tbSalaDetails.ReadOnly = true;
            this.tbSalaDetails.Size = new System.Drawing.Size(260, 29);
            this.tbSalaDetails.TabIndex = 54;
            // 
            // frmClasesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.tbSalaDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cBHora);
            this.Controls.Add(this.dGVClases);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.cBSala);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cBActividad);
            this.Controls.Add(this.pBClases);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClasesAdmin";
            this.Text = "frmClasesAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClasesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBSala;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cBActividad;
        private System.Windows.Forms.PictureBox pBClases;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.DataGridView dGVClases;
        private System.Windows.Forms.ComboBox cBHora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSalaDetails;
    }
}