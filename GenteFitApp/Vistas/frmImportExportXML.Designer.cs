namespace GenteFitApp.Vistas
{
    partial class frmImportExportXML
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
            this.cbTablaSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTablaSelect
            // 
            this.cbTablaSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTablaSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.cbTablaSelect.FormattingEnabled = true;
            this.cbTablaSelect.Items.AddRange(new object[] {
            "Actividad",
            "Administrador",
            "Clase",
            "Cliente",
            "Monitor",
            "Persona",
            "Reserva",
            "Sala"});
            this.cbTablaSelect.Location = new System.Drawing.Point(449, 146);
            this.cbTablaSelect.Name = "cbTablaSelect";
            this.cbTablaSelect.Size = new System.Drawing.Size(169, 29);
            this.cbTablaSelect.Sorted = true;
            this.cbTablaSelect.TabIndex = 0;
            this.cbTablaSelect.SelectedIndexChanged += new System.EventHandler(this.cbTablaSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(445, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Escoje una tabla de datos.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(411, 174);
            this.dataGridView1.TabIndex = 20;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExport.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExport.Location = new System.Drawing.Point(449, 403);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(169, 38);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Exportar a Odoo";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImport.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnImport.Location = new System.Drawing.Point(691, 403);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(169, 38);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Importar de Odoo";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnVolver.Location = new System.Drawing.Point(99, 651);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 40);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmImportExportXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTablaSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportExportXML";
            this.Text = "Import-Export XMLs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTablaSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnVolver;
    }
}