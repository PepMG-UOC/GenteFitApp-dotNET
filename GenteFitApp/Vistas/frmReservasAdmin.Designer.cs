namespace GenteFitApp.Vistas
{
    partial class frmReservasAdmin
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
            this.txtbxHora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxAforo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPlazas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxActividad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxFecha = new System.Windows.Forms.TextBox();
            this.txtbxMonitor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dGVUsersPlaza = new System.Windows.Forms.DataGridView();
            this.dGVUsersEspera = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsersPlaza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsersEspera)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxHora
            // 
            this.txtbxHora.Enabled = false;
            this.txtbxHora.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxHora.Location = new System.Drawing.Point(288, 105);
            this.txtbxHora.Name = "txtbxHora";
            this.txtbxHora.ReadOnly = true;
            this.txtbxHora.Size = new System.Drawing.Size(116, 29);
            this.txtbxHora.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(294, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 40;
            this.label6.Text = "Lista de espera:";
            // 
            // txtbxAforo
            // 
            this.txtbxAforo.Enabled = false;
            this.txtbxAforo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxAforo.Location = new System.Drawing.Point(485, 506);
            this.txtbxAforo.Name = "txtbxAforo";
            this.txtbxAforo.Size = new System.Drawing.Size(43, 29);
            this.txtbxAforo.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(298, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Plazas libres:";
            // 
            // txtbxPlazas
            // 
            this.txtbxPlazas.Enabled = false;
            this.txtbxPlazas.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxPlazas.Location = new System.Drawing.Point(406, 506);
            this.txtbxPlazas.Name = "txtbxPlazas";
            this.txtbxPlazas.Size = new System.Drawing.Size(46, 29);
            this.txtbxPlazas.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(37, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 36;
            this.label4.Text = "Usuarios con plaza:";
            // 
            // txtbxActividad
            // 
            this.txtbxActividad.Enabled = false;
            this.txtbxActividad.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxActividad.Location = new System.Drawing.Point(41, 44);
            this.txtbxActividad.Name = "txtbxActividad";
            this.txtbxActividad.ReadOnly = true;
            this.txtbxActividad.Size = new System.Drawing.Size(182, 29);
            this.txtbxActividad.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(284, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Hora";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnVolver.Location = new System.Drawing.Point(22, 517);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 40);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(48, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Actividad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(48, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha";
            // 
            // txtbxFecha
            // 
            this.txtbxFecha.Enabled = false;
            this.txtbxFecha.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxFecha.Location = new System.Drawing.Point(41, 105);
            this.txtbxFecha.Name = "txtbxFecha";
            this.txtbxFecha.ReadOnly = true;
            this.txtbxFecha.Size = new System.Drawing.Size(182, 29);
            this.txtbxFecha.TabIndex = 28;
            // 
            // txtbxMonitor
            // 
            this.txtbxMonitor.Enabled = false;
            this.txtbxMonitor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtbxMonitor.Location = new System.Drawing.Point(287, 44);
            this.txtbxMonitor.Name = "txtbxMonitor";
            this.txtbxMonitor.ReadOnly = true;
            this.txtbxMonitor.Size = new System.Drawing.Size(182, 29);
            this.txtbxMonitor.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label8.Location = new System.Drawing.Point(294, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "Monitor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "de";
            // 
            // dGVUsersPlaza
            // 
            this.dGVUsersPlaza.AllowUserToAddRows = false;
            this.dGVUsersPlaza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVUsersPlaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsersPlaza.Location = new System.Drawing.Point(30, 188);
            this.dGVUsersPlaza.MultiSelect = false;
            this.dGVUsersPlaza.Name = "dGVUsersPlaza";
            this.dGVUsersPlaza.ReadOnly = true;
            this.dGVUsersPlaza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUsersPlaza.Size = new System.Drawing.Size(224, 297);
            this.dGVUsersPlaza.TabIndex = 49;
            // 
            // dGVUsersEspera
            // 
            this.dGVUsersEspera.AllowUserToAddRows = false;
            this.dGVUsersEspera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGVUsersEspera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsersEspera.Location = new System.Drawing.Point(288, 188);
            this.dGVUsersEspera.MultiSelect = false;
            this.dGVUsersEspera.Name = "dGVUsersEspera";
            this.dGVUsersEspera.ReadOnly = true;
            this.dGVUsersEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVUsersEspera.Size = new System.Drawing.Size(224, 297);
            this.dGVUsersEspera.TabIndex = 50;
            // 
            // frmReservasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(571, 569);
            this.Controls.Add(this.dGVUsersEspera);
            this.Controls.Add(this.dGVUsersPlaza);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbxMonitor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbxHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxAforo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxPlazas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxActividad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservasAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReservasAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsersPlaza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsersEspera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbxHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxAforo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxPlazas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxActividad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxFecha;
        private System.Windows.Forms.TextBox txtbxMonitor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGVUsersPlaza;
        private System.Windows.Forms.DataGridView dGVUsersEspera;
    }
}