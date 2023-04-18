namespace GenteFitApp.Vistas
{
    partial class frmGestionUsers
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbCodigoPost = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rBCliente = new System.Windows.Forms.RadioButton();
            this.rBMonitor = new System.Windows.Forms.RadioButton();
            this.rBAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gBDetallesUser = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gBDetallesUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnVolver.Location = new System.Drawing.Point(69, 635);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(110, 40);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbEmail.Location = new System.Drawing.Point(349, 126);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(231, 29);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Text = "eMail";
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbDNI
            // 
            this.tbDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDNI.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDNI.Location = new System.Drawing.Point(100, 16);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(190, 29);
            this.tbDNI.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Datos:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "DNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GenteFitApp.Properties.Resources.gestionUsuario;
            this.pictureBox1.Location = new System.Drawing.Point(669, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlta
            // 
            this.btnAlta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlta.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAlta.Location = new System.Drawing.Point(391, 483);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(110, 40);
            this.btnAlta.TabIndex = 21;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnModificar.Location = new System.Drawing.Point(391, 529);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 40);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbNombre.Location = new System.Drawing.Point(100, 60);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 29);
            this.tbNombre.TabIndex = 24;
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbApellido.Location = new System.Drawing.Point(100, 102);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(190, 29);
            this.tbApellido.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label6.Location = new System.Drawing.Point(12, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "C.P.";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDireccion.Location = new System.Drawing.Point(100, 146);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(190, 29);
            this.tbDireccion.TabIndex = 30;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProvincia.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbProvincia.Location = new System.Drawing.Point(100, 191);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(190, 29);
            this.tbProvincia.TabIndex = 31;
            // 
            // tbCodigoPost
            // 
            this.tbCodigoPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigoPost.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbCodigoPost.Location = new System.Drawing.Point(100, 236);
            this.tbCodigoPost.Name = "tbCodigoPost";
            this.tbCodigoPost.Size = new System.Drawing.Size(190, 29);
            this.tbCodigoPost.TabIndex = 32;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::GenteFitApp.Properties.Resources.mailIcon;
            this.pictureBox2.Location = new System.Drawing.Point(303, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.button1.Location = new System.Drawing.Point(534, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rBCliente
            // 
            this.rBCliente.AutoSize = true;
            this.rBCliente.Checked = true;
            this.rBCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rBCliente.Location = new System.Drawing.Point(6, 17);
            this.rBCliente.Name = "rBCliente";
            this.rBCliente.Size = new System.Drawing.Size(81, 25);
            this.rBCliente.TabIndex = 37;
            this.rBCliente.TabStop = true;
            this.rBCliente.Text = "Cliente";
            this.rBCliente.UseVisualStyleBackColor = true;
            // 
            // rBMonitor
            // 
            this.rBMonitor.AutoSize = true;
            this.rBMonitor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rBMonitor.Location = new System.Drawing.Point(6, 49);
            this.rBMonitor.Name = "rBMonitor";
            this.rBMonitor.Size = new System.Drawing.Size(90, 25);
            this.rBMonitor.TabIndex = 38;
            this.rBMonitor.Text = "Monitor";
            this.rBMonitor.UseVisualStyleBackColor = true;
            // 
            // rBAdmin
            // 
            this.rBAdmin.AutoSize = true;
            this.rBAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rBAdmin.Location = new System.Drawing.Point(6, 81);
            this.rBAdmin.Name = "rBAdmin";
            this.rBAdmin.Size = new System.Drawing.Size(136, 25);
            this.rBAdmin.TabIndex = 39;
            this.rBAdmin.Text = "Administrador";
            this.rBAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rBMonitor);
            this.groupBox1.Controls.Add(this.rBAdmin);
            this.groupBox1.Controls.Add(this.rBCliente);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(612, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 116);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // gBDetallesUser
            // 
            this.gBDetallesUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDetallesUser.Controls.Add(this.tbDNI);
            this.gBDetallesUser.Controls.Add(this.label1);
            this.gBDetallesUser.Controls.Add(this.label3);
            this.gBDetallesUser.Controls.Add(this.tbNombre);
            this.gBDetallesUser.Controls.Add(this.tbCodigoPost);
            this.gBDetallesUser.Controls.Add(this.tbApellido);
            this.gBDetallesUser.Controls.Add(this.tbProvincia);
            this.gBDetallesUser.Controls.Add(this.label4);
            this.gBDetallesUser.Controls.Add(this.tbDireccion);
            this.gBDetallesUser.Controls.Add(this.label5);
            this.gBDetallesUser.Controls.Add(this.label7);
            this.gBDetallesUser.Controls.Add(this.label6);
            this.gBDetallesUser.Enabled = false;
            this.gBDetallesUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gBDetallesUser.Location = new System.Drawing.Point(291, 163);
            this.gBDetallesUser.Name = "gBDetallesUser";
            this.gBDetallesUser.Size = new System.Drawing.Size(305, 269);
            this.gBDetallesUser.TabIndex = 41;
            this.gBDetallesUser.TabStop = false;
            // 
            // frmGestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.gBDetallesUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGestionUsers";
            this.Text = "frmGestionUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBDetallesUser.ResumeLayout(false);
            this.gBDetallesUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbCodigoPost;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rBCliente;
        private System.Windows.Forms.RadioButton rBMonitor;
        private System.Windows.Forms.RadioButton rBAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gBDetallesUser;
    }
}