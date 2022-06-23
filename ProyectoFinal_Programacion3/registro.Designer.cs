
namespace ProyectoFinal_Programacion3
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxconf = new System.Windows.Forms.CheckBox();
            this.checkBoxcontra = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnregistro = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxconf
            // 
            this.checkBoxconf.AutoSize = true;
            this.checkBoxconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxconf.Location = new System.Drawing.Point(179, 317);
            this.checkBoxconf.Name = "checkBoxconf";
            this.checkBoxconf.Size = new System.Drawing.Size(117, 17);
            this.checkBoxconf.TabIndex = 78;
            this.checkBoxconf.Text = "Mostrar contraseña";
            this.checkBoxconf.UseVisualStyleBackColor = true;
            this.checkBoxconf.CheckedChanged += new System.EventHandler(this.checkBoxconf_CheckedChanged);
            // 
            // checkBoxcontra
            // 
            this.checkBoxcontra.AutoSize = true;
            this.checkBoxcontra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxcontra.Location = new System.Drawing.Point(179, 218);
            this.checkBoxcontra.Name = "checkBoxcontra";
            this.checkBoxcontra.Size = new System.Drawing.Size(117, 17);
            this.checkBoxcontra.TabIndex = 77;
            this.checkBoxcontra.Text = "Mostrar contraseña";
            this.checkBoxcontra.UseVisualStyleBackColor = true;
            this.checkBoxcontra.CheckedChanged += new System.EventHandler(this.checkBoxcontra_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label2.Location = new System.Drawing.Point(82, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 76;
            this.label2.Text = "Confirmación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.label1.Location = new System.Drawing.Point(79, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Contraseña";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lbnombre.Location = new System.Drawing.Point(79, 66);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(75, 23);
            this.lbnombre.TabIndex = 74;
            this.lbnombre.Text = "Usuario";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirm.Location = new System.Drawing.Point(83, 273);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '#';
            this.txtconfirm.Size = new System.Drawing.Size(191, 27);
            this.txtconfirm.TabIndex = 73;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(83, 90);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(191, 27);
            this.txtuser.TabIndex = 72;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(83, 179);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '#';
            this.txtpass.Size = new System.Drawing.Size(191, 27);
            this.txtpass.TabIndex = 71;
            // 
            // btnregistro
            // 
            this.btnregistro.BackColor = System.Drawing.Color.DarkCyan;
            this.btnregistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistro.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnregistro.Location = new System.Drawing.Point(260, 400);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(181, 48);
            this.btnregistro.TabIndex = 70;
            this.btnregistro.Text = "Continuar";
            this.btnregistro.UseVisualStyleBackColor = false;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 80;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem1});
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sALIRToolStripMenuItem.Text = "OPCIONES";
            // 
            // sALIRToolStripMenuItem1
            // 
            this.sALIRToolStripMenuItem1.Name = "sALIRToolStripMenuItem1";
            this.sALIRToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sALIRToolStripMenuItem1.Text = "SALIR";
            this.sALIRToolStripMenuItem1.Click += new System.EventHandler(this.sALIRToolStripMenuItem1_Click);
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxconf);
            this.Controls.Add(this.checkBoxcontra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "registro";
            this.Text = "registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxconf;
        private System.Windows.Forms.CheckBox checkBoxcontra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem1;
    }
}