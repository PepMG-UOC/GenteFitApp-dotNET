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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbdias = new System.Windows.Forms.Label();
            this.dGVEventos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEventos)).BeginInit();
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
            // dGVEventos
            // 
            this.dGVEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dGVEventos.BackgroundColor = System.Drawing.Color.White;
            this.dGVEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dGVEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEventos.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVEventos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGVEventos.Location = new System.Drawing.Point(30, 5);
            this.dGVEventos.Name = "dGVEventos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVEventos.RowHeadersVisible = false;
            this.dGVEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEventos.Size = new System.Drawing.Size(132, 77);
            this.dGVEventos.TabIndex = 1;
            this.dGVEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVEventos_CellClick);
            // 
            // UserControlDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dGVEventos);
            this.Controls.Add(this.lbdias);
            this.Name = "UserControlDias";
            this.Size = new System.Drawing.Size(165, 85);
            this.Load += new System.EventHandler(this.UserControlDias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEventos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdias;
        private System.Windows.Forms.DataGridView dGVEventos;
    }
}
