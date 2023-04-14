namespace GenteFitApp.Vistas
{
    partial class UserControlDias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdias = new System.Windows.Forms.Label();
            this.fLPClase = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbdias
            // 
            this.lbdias.AutoSize = true;
            this.lbdias.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lbdias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbdias.Location = new System.Drawing.Point(5, 5);
            this.lbdias.Name = "lbdias";
            this.lbdias.Size = new System.Drawing.Size(28, 21);
            this.lbdias.TabIndex = 0;
            this.lbdias.Text = "00";
            // 
            // fLPClase
            // 
            this.fLPClase.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fLPClase.Location = new System.Drawing.Point(39, 5);
            this.fLPClase.Name = "fLPClase";
            this.fLPClase.Size = new System.Drawing.Size(123, 77);
            this.fLPClase.TabIndex = 1;
            // 
            // UserControlDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fLPClase);
            this.Controls.Add(this.lbdias);
            this.Name = "UserControlDias";
            this.Size = new System.Drawing.Size(165, 85);
            this.Load += new System.EventHandler(this.UserControlDias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdias;
        private System.Windows.Forms.FlowLayoutPanel fLPClase;
    }
}
