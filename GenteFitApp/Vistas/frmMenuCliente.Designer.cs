namespace GenteFitApp.Vistas
{
    partial class frmMenuCliente
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbClases = new System.Windows.Forms.PictureBox();
            this.pbMisClases = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMisClases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSalir.Location = new System.Drawing.Point(99, 651);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::GenteFitApp.Properties.Resources.GenteFit_Entrena_y_vive;
            this.pictureBox3.Location = new System.Drawing.Point(944, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(222, 235);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pbClases
            // 
            this.pbClases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbClases.Image = global::GenteFitApp.Properties.Resources.mnuClClases;
            this.pbClases.Location = new System.Drawing.Point(399, 23);
            this.pbClases.Name = "pbClases";
            this.pbClases.Size = new System.Drawing.Size(442, 262);
            this.pbClases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClases.TabIndex = 13;
            this.pbClases.TabStop = false;
            this.pbClases.Click += new System.EventHandler(this.pbClases_Click);
            // 
            // pbMisClases
            // 
            this.pbMisClases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbMisClases.Image = global::GenteFitApp.Properties.Resources.mnuClMiClases;
            this.pbMisClases.Location = new System.Drawing.Point(399, 314);
            this.pbMisClases.Name = "pbMisClases";
            this.pbMisClases.Size = new System.Drawing.Size(442, 262);
            this.pbMisClases.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMisClases.TabIndex = 14;
            this.pbMisClases.TabStop = false;
            this.pbMisClases.Click += new System.EventHandler(this.pbMisClases_Click);
            // 
            // frmMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.pbMisClases);
            this.Controls.Add(this.pbClases);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuCliente";
            this.Text = "frmMenuCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMisClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbClases;
        private System.Windows.Forms.PictureBox pbMisClases;
    }
}