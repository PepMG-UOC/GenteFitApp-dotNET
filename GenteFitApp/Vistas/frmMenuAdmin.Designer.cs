namespace GenteFitApp.Vistas
{
    partial class frmMenuAdmin
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbUsuarios = new System.Windows.Forms.PictureBox();
            this.pbReservas = new System.Windows.Forms.PictureBox();
            this.pbCentro = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalir.Location = new System.Drawing.Point(399, 650);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbUsuarios
            // 
            this.pbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbUsuarios.Image = global::GenteFitApp.Properties.Resources.mnuAdmGestUser;
            this.pbUsuarios.Location = new System.Drawing.Point(399, 23);
            this.pbUsuarios.Name = "pbUsuarios";
            this.pbUsuarios.Size = new System.Drawing.Size(446, 191);
            this.pbUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuarios.TabIndex = 8;
            this.pbUsuarios.TabStop = false;
            this.pbUsuarios.Click += new System.EventHandler(this.pbUsuarios_Click);
            // 
            // pbReservas
            // 
            this.pbReservas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbReservas.Image = global::GenteFitApp.Properties.Resources.mnuAdmGestReservas;
            this.pbReservas.Location = new System.Drawing.Point(399, 229);
            this.pbReservas.Name = "pbReservas";
            this.pbReservas.Size = new System.Drawing.Size(446, 191);
            this.pbReservas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReservas.TabIndex = 9;
            this.pbReservas.TabStop = false;
            this.pbReservas.Click += new System.EventHandler(this.pbReservas_Click);
            // 
            // pbCentro
            // 
            this.pbCentro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbCentro.Image = global::GenteFitApp.Properties.Resources.mnuAdmGestCentro;
            this.pbCentro.Location = new System.Drawing.Point(399, 436);
            this.pbCentro.Name = "pbCentro";
            this.pbCentro.Size = new System.Drawing.Size(446, 191);
            this.pbCentro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCentro.TabIndex = 10;
            this.pbCentro.TabStop = false;
            this.pbCentro.Click += new System.EventHandler(this.pbCentro_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::GenteFitApp.Properties.Resources.GenteFit_Entrena_y_vive;
            this.pictureBox3.Location = new System.Drawing.Point(944, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 235);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbCentro);
            this.Controls.Add(this.pbReservas);
            this.Controls.Add(this.pbUsuarios);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdmin";
            this.Text = "frmMenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCentro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbUsuarios;
        private System.Windows.Forms.PictureBox pbReservas;
        private System.Windows.Forms.PictureBox pbCentro;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}