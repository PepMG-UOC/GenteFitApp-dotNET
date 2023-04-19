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
            this.btnBaja = new System.Windows.Forms.Button();
            this.rBCliente = new System.Windows.Forms.RadioButton();
            this.rBMonitor = new System.Windows.Forms.RadioButton();
            this.rBAdmin = new System.Windows.Forms.RadioButton();
            this.gBTipo = new System.Windows.Forms.GroupBox();
            this.gBDetallesUser = new System.Windows.Forms.GroupBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbApellido2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.lbSueldo = new System.Windows.Forms.Label();
            this.lbSueldo2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gBTipo.SuspendLayout();
            this.gBDetallesUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbDNI
            // 
            this.tbDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDNI.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDNI.Location = new System.Drawing.Point(100, 11);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(190, 29);
            this.tbDNI.TabIndex = 17;
            this.tbDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDNI_KeyDown);
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
            this.label1.Location = new System.Drawing.Point(8, 14);
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
            this.btnAlta.Location = new System.Drawing.Point(327, 560);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(110, 40);
            this.btnAlta.TabIndex = 21;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnModificar.Location = new System.Drawing.Point(327, 560);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 40);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label3.Location = new System.Drawing.Point(8, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbNombre.Location = new System.Drawing.Point(100, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(190, 29);
            this.tbNombre.TabIndex = 24;
            // 
            // tbApellido
            // 
            this.tbApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbApellido.Location = new System.Drawing.Point(100, 100);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(190, 29);
            this.tbApellido.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label4.Location = new System.Drawing.Point(8, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellido 1";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label5.Location = new System.Drawing.Point(8, 191);
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
            this.label6.Location = new System.Drawing.Point(8, 236);
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
            this.label7.Location = new System.Drawing.Point(9, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "C.P.";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbDireccion.Location = new System.Drawing.Point(100, 188);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(190, 29);
            this.tbDireccion.TabIndex = 30;
            // 
            // tbProvincia
            // 
            this.tbProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProvincia.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbProvincia.Location = new System.Drawing.Point(100, 233);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(190, 29);
            this.tbProvincia.TabIndex = 31;
            // 
            // tbCodigoPost
            // 
            this.tbCodigoPost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigoPost.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbCodigoPost.Location = new System.Drawing.Point(100, 278);
            this.tbCodigoPost.Name = "tbCodigoPost";
            this.tbCodigoPost.Size = new System.Drawing.Size(190, 29);
            this.tbCodigoPost.TabIndex = 32;
            this.tbCodigoPost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodigoPost_KeyDown);
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
            // btnBaja
            // 
            this.btnBaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnBaja.Location = new System.Drawing.Point(470, 560);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(110, 40);
            this.btnBaja.TabIndex = 36;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // rBCliente
            // 
            this.rBCliente.AutoSize = true;
            this.rBCliente.Checked = true;
            this.rBCliente.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rBCliente.Location = new System.Drawing.Point(6, 28);
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
            this.rBMonitor.Location = new System.Drawing.Point(6, 60);
            this.rBMonitor.Name = "rBMonitor";
            this.rBMonitor.Size = new System.Drawing.Size(90, 25);
            this.rBMonitor.TabIndex = 38;
            this.rBMonitor.Text = "Monitor";
            this.rBMonitor.UseVisualStyleBackColor = true;
            this.rBMonitor.CheckedChanged += new System.EventHandler(this.rBMonitor_CheckedChanged);
            // 
            // rBAdmin
            // 
            this.rBAdmin.AutoSize = true;
            this.rBAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rBAdmin.Location = new System.Drawing.Point(6, 92);
            this.rBAdmin.Name = "rBAdmin";
            this.rBAdmin.Size = new System.Drawing.Size(136, 25);
            this.rBAdmin.TabIndex = 39;
            this.rBAdmin.Text = "Administrador";
            this.rBAdmin.UseVisualStyleBackColor = true;
            // 
            // gBTipo
            // 
            this.gBTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBTipo.Controls.Add(this.rBMonitor);
            this.gBTipo.Controls.Add(this.rBAdmin);
            this.gBTipo.Controls.Add(this.rBCliente);
            this.gBTipo.Enabled = false;
            this.gBTipo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.gBTipo.Location = new System.Drawing.Point(630, 306);
            this.gBTipo.Name = "gBTipo";
            this.gBTipo.Size = new System.Drawing.Size(165, 126);
            this.gBTipo.TabIndex = 40;
            this.gBTipo.TabStop = false;
            this.gBTipo.Text = "Tipo";
            // 
            // gBDetallesUser
            // 
            this.gBDetallesUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDetallesUser.Controls.Add(this.tbPass);
            this.gBDetallesUser.Controls.Add(this.label9);
            this.gBDetallesUser.Controls.Add(this.tbApellido2);
            this.gBDetallesUser.Controls.Add(this.label8);
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
            this.gBDetallesUser.Size = new System.Drawing.Size(305, 356);
            this.gBDetallesUser.TabIndex = 41;
            this.gBDetallesUser.TabStop = false;
            // 
            // tbPass
            // 
            this.tbPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPass.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbPass.Location = new System.Drawing.Point(100, 324);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(190, 29);
            this.tbPass.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label9.Location = new System.Drawing.Point(9, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Password";
            // 
            // tbApellido2
            // 
            this.tbApellido2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbApellido2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbApellido2.Location = new System.Drawing.Point(100, 145);
            this.tbApellido2.Name = "tbApellido2";
            this.tbApellido2.Size = new System.Drawing.Size(190, 29);
            this.tbApellido2.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label8.Location = new System.Drawing.Point(8, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 34;
            this.label8.Text = "Apellido 2";
            // 
            // tbSueldo
            // 
            this.tbSueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSueldo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbSueldo.Location = new System.Drawing.Point(700, 448);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(54, 29);
            this.tbSueldo.TabIndex = 43;
            this.tbSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbSueldo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSueldo_KeyDown);
            // 
            // lbSueldo
            // 
            this.lbSueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSueldo.AutoSize = true;
            this.lbSueldo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lbSueldo.Location = new System.Drawing.Point(632, 451);
            this.lbSueldo.Name = "lbSueldo";
            this.lbSueldo.Size = new System.Drawing.Size(62, 21);
            this.lbSueldo.TabIndex = 42;
            this.lbSueldo.Text = "Sueldo";
            // 
            // lbSueldo2
            // 
            this.lbSueldo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSueldo2.AutoSize = true;
            this.lbSueldo2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.lbSueldo2.Location = new System.Drawing.Point(760, 451);
            this.lbSueldo2.Name = "lbSueldo2";
            this.lbSueldo2.Size = new System.Drawing.Size(36, 21);
            this.lbSueldo2.TabIndex = 44;
            this.lbSueldo2.Text = "€/h";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::GenteFitApp.Properties.Resources.GenteFit_Entrena_y_vive;
            this.pictureBox3.Location = new System.Drawing.Point(865, 380);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // frmGestionUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbSueldo2);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.lbSueldo);
            this.Controls.Add(this.gBDetallesUser);
            this.Controls.Add(this.gBTipo);
            this.Controls.Add(this.btnBaja);
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
            this.Load += new System.EventHandler(this.frmGestionUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gBTipo.ResumeLayout(false);
            this.gBTipo.PerformLayout();
            this.gBDetallesUser.ResumeLayout(false);
            this.gBDetallesUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.RadioButton rBCliente;
        private System.Windows.Forms.RadioButton rBMonitor;
        private System.Windows.Forms.RadioButton rBAdmin;
        private System.Windows.Forms.GroupBox gBTipo;
        private System.Windows.Forms.GroupBox gBDetallesUser;
        private System.Windows.Forms.TextBox tbApellido2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Label lbSueldo;
        private System.Windows.Forms.Label lbSueldo2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}