namespace GenteFitApp.Vistas
{
    partial class frmGestionCentro
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
            this.pBActividades = new System.Windows.Forms.PictureBox();
            this.pBClases = new System.Windows.Forms.PictureBox();
            this.pBSalas = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pBActividades
            // 
            this.pBActividades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBActividades.Image = global::GenteFitApp.Properties.Resources.actividades;
            this.pBActividades.Location = new System.Drawing.Point(699, 104);
            this.pBActividades.Name = "pBActividades";
            this.pBActividades.Size = new System.Drawing.Size(396, 211);
            this.pBActividades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBActividades.TabIndex = 21;
            this.pBActividades.TabStop = false;
            this.pBActividades.Click += new System.EventHandler(this.pBActividades_Click);
            // 
            // pBClases
            // 
            this.pBClases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBClases.Image = global::GenteFitApp.Properties.Resources.clases;
            this.pBClases.Location = new System.Drawing.Point(223, 104);
            this.pBClases.Name = "pBClases";
            this.pBClases.Size = new System.Drawing.Size(368, 211);
            this.pBClases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBClases.TabIndex = 22;
            this.pBClases.TabStop = false;
            this.pBClases.Click += new System.EventHandler(this.pBClases_Click);
            // 
            // pBSalas
            // 
            this.pBSalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pBSalas.Image = global::GenteFitApp.Properties.Resources.salas;
            this.pBSalas.Location = new System.Drawing.Point(455, 429);
            this.pBSalas.Name = "pBSalas";
            this.pBSalas.Size = new System.Drawing.Size(388, 211);
            this.pBSalas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBSalas.TabIndex = 24;
            this.pBSalas.TabStop = false;
            this.pBSalas.Click += new System.EventHandler(this.pBSalas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GenteFitApp.Properties.Resources.casa;
            this.pictureBox1.Location = new System.Drawing.Point(523, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnVolver.Location = new System.Drawing.Point(69, 635);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 40);
            this.btnVolver.TabIndex = 26;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::GenteFitApp.Properties.Resources.GenteFit_Entrena_y_vive;
            this.pictureBox3.Location = new System.Drawing.Point(977, 539);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 101);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // frmGestionCentro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBSalas);
            this.Controls.Add(this.pBClases);
            this.Controls.Add(this.pBActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionCentro";
            this.Text = "frmGestionCentro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pBActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSalas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBActividades;
        private System.Windows.Forms.PictureBox pBClases;
        private System.Windows.Forms.PictureBox pBSalas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}