namespace GenteFitApp.Vistas
{
    partial class frmLogging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogging));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbPassw = new System.Windows.Forms.TextBox();
            this.btnAccede = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::GenteFitApp.Properties.Resources.User_avatar_svg;
            this.pictureBox2.Location = new System.Drawing.Point(460, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::GenteFitApp.Properties.Resources.GenteFit_Entrena_y_vive;
            this.pictureBox1.Location = new System.Drawing.Point(448, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbEmail.Location = new System.Drawing.Point(525, 419);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(203, 29);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Text = "eMail";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(460, 468);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // tbPassw
            // 
            this.tbPassw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassw.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.tbPassw.Location = new System.Drawing.Point(525, 475);
            this.tbPassw.Name = "tbPassw";
            this.tbPassw.Size = new System.Drawing.Size(203, 29);
            this.tbPassw.TabIndex = 4;
            this.tbPassw.UseSystemPasswordChar = true;
            this.tbPassw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassw_KeyDown);
            // 
            // btnAccede
            // 
            this.btnAccede.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccede.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAccede.Location = new System.Drawing.Point(541, 544);
            this.btnAccede.Name = "btnAccede";
            this.btnAccede.Size = new System.Drawing.Size(110, 40);
            this.btnAccede.TabIndex = 5;
            this.btnAccede.Text = "Accede";
            this.btnAccede.UseVisualStyleBackColor = true;
            this.btnAccede.Click += new System.EventHandler(this.btnAccede_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::GenteFitApp.Properties.Resources.ExitBtn;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(12, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // frmLogging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 714);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccede);
            this.Controls.Add(this.tbPassw);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogging";
            this.Text = "frmLogging";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbPassw;
        private System.Windows.Forms.Button btnAccede;
        private System.Windows.Forms.Button btnExit;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}