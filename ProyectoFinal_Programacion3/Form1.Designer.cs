
namespace ProyectoFinal_Programacion3
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxlg = new System.Windows.Forms.CheckBox();
            this.btnloggin = new System.Windows.Forms.Button();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.lbcontrasena = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 27);
            this.label5.TabIndex = 47;
            this.label5.Text = "👜";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 46;
            this.label4.Text = "Beautiful Angel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 79);
            this.label3.TabIndex = 45;
            this.label3.Text = "STORE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxlg
            // 
            this.checkBoxlg.AutoSize = true;
            this.checkBoxlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxlg.Location = new System.Drawing.Point(183, 328);
            this.checkBoxlg.Name = "checkBoxlg";
            this.checkBoxlg.Size = new System.Drawing.Size(117, 17);
            this.checkBoxlg.TabIndex = 43;
            this.checkBoxlg.Text = "Mostrar contraseña";
            this.checkBoxlg.UseVisualStyleBackColor = true;
            this.checkBoxlg.CheckedChanged += new System.EventHandler(this.checkBoxlg_CheckedChanged);
            // 
            // btnloggin
            // 
            this.btnloggin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnloggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnloggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnloggin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloggin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnloggin.Location = new System.Drawing.Point(247, 418);
            this.btnloggin.Name = "btnloggin";
            this.btnloggin.Size = new System.Drawing.Size(205, 48);
            this.btnloggin.TabIndex = 40;
            this.btnloggin.Text = "Iniciar sesión";
            this.btnloggin.UseVisualStyleBackColor = false;
            this.btnloggin.Click += new System.EventHandler(this.btnloggin_Click);
            // 
            // txtcon
            // 
            this.txtcon.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcon.Location = new System.Drawing.Point(109, 282);
            this.txtcon.Name = "txtcon";
            this.txtcon.PasswordChar = '#';
            this.txtcon.Size = new System.Drawing.Size(191, 27);
            this.txtcon.TabIndex = 39;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(109, 178);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(191, 27);
            this.txtnom.TabIndex = 38;
            // 
            // lbcontrasena
            // 
            this.lbcontrasena.AutoSize = true;
            this.lbcontrasena.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F);
            this.lbcontrasena.Location = new System.Drawing.Point(105, 258);
            this.lbcontrasena.Name = "lbcontrasena";
            this.lbcontrasena.Size = new System.Drawing.Size(106, 23);
            this.lbcontrasena.TabIndex = 37;
            this.lbcontrasena.Text = "Contraseña";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(104, 149);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(80, 23);
            this.lbnombre.TabIndex = 36;
            this.lbnombre.Text = "Usuario ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(307, 475);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 13);
            this.linkLabel1.TabIndex = 52;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "REGISTRARSE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(741, 498);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBoxlg);
            this.Controls.Add(this.btnloggin);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.lbcontrasena);
            this.Controls.Add(this.lbnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxlg;
        private System.Windows.Forms.Button btnloggin;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label lbcontrasena;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

