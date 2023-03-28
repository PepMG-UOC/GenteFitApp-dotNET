namespace GenteFitApp.Vistas
{
    partial class frmTempSala
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVnum = new System.Windows.Forms.TextBox();
            this.tbVNPlazas = new System.Windows.Forms.TextBox();
            this.tbVDimen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDimension = new System.Windows.Forms.TextBox();
            this.tbPlazas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbPedirSala = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sala";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMostrar.Location = new System.Drawing.Point(218, 50);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(87, 35);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbVDimen);
            this.panel1.Controls.Add(this.tbVNPlazas);
            this.panel1.Controls.Add(this.tbVnum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 165);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(40, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dimension m2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(77, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nº Plazas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(68, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos de la sala:";
            // 
            // tbVnum
            // 
            this.tbVnum.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVnum.Location = new System.Drawing.Point(170, 41);
            this.tbVnum.Name = "tbVnum";
            this.tbVnum.Size = new System.Drawing.Size(100, 29);
            this.tbVnum.TabIndex = 4;
            // 
            // tbVNPlazas
            // 
            this.tbVNPlazas.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVNPlazas.Location = new System.Drawing.Point(170, 76);
            this.tbVNPlazas.Name = "tbVNPlazas";
            this.tbVNPlazas.Size = new System.Drawing.Size(100, 29);
            this.tbVNPlazas.TabIndex = 5;
            // 
            // tbVDimen
            // 
            this.tbVDimen.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbVDimen.Location = new System.Drawing.Point(170, 111);
            this.tbVDimen.Name = "tbVDimen";
            this.tbVDimen.Size = new System.Drawing.Size(100, 29);
            this.tbVDimen.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(51, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nueva Sala:";
            // 
            // tbDimension
            // 
            this.tbDimension.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDimension.Location = new System.Drawing.Point(156, 361);
            this.tbDimension.Name = "tbDimension";
            this.tbDimension.Size = new System.Drawing.Size(100, 29);
            this.tbDimension.TabIndex = 10;
            // 
            // tbPlazas
            // 
            this.tbPlazas.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbPlazas.Location = new System.Drawing.Point(156, 326);
            this.tbPlazas.Name = "tbPlazas";
            this.tbPlazas.Size = new System.Drawing.Size(100, 29);
            this.tbPlazas.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.Location = new System.Drawing.Point(26, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Dimension m2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label8.Location = new System.Drawing.Point(63, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nº Plazas:";
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnCrear.Location = new System.Drawing.Point(156, 409);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(87, 35);
            this.btnCrear.TabIndex = 11;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalir.Location = new System.Drawing.Point(39, 489);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbPedirSala
            // 
            this.tbPedirSala.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbPedirSala.Location = new System.Drawing.Point(50, 54);
            this.tbPedirSala.Name = "tbPedirSala";
            this.tbPedirSala.Size = new System.Drawing.Size(100, 29);
            this.tbPedirSala.TabIndex = 13;
            // 
            // frmTempSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 546);
            this.Controls.Add(this.tbPedirSala);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.tbDimension);
            this.Controls.Add(this.tbPlazas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTempSala";
            this.Text = "frmTempSala";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVDimen;
        private System.Windows.Forms.TextBox tbVNPlazas;
        private System.Windows.Forms.TextBox tbVnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDimension;
        private System.Windows.Forms.TextBox tbPlazas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbPedirSala;
    }
}