namespace Clase_DPS1
{
    partial class central_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(central_admin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_hi = new System.Windows.Forms.Button();
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_hc = new System.Windows.Forms.Button();
            this.btn_cs = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_a = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 213);
            this.textBox1.TabIndex = 0;
            // 
            // btn_hi
            // 
            this.btn_hi.Location = new System.Drawing.Point(522, 103);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(141, 28);
            this.btn_hi.TabIndex = 1;
            this.btn_hi.Text = "Registro Inventario";
            this.btn_hi.UseVisualStyleBackColor = true;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // btn_cd
            // 
            this.btn_cd.Location = new System.Drawing.Point(522, 163);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(141, 28);
            this.btn_cd.TabIndex = 2;
            this.btn_cd.Text = "Corte diario";
            this.btn_cd.UseVisualStyleBackColor = true;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_hc
            // 
            this.btn_hc.Location = new System.Drawing.Point(522, 229);
            this.btn_hc.Name = "btn_hc";
            this.btn_hc.Size = new System.Drawing.Size(141, 28);
            this.btn_hc.TabIndex = 3;
            this.btn_hc.Text = "Historial de corte";
            this.btn_hc.UseVisualStyleBackColor = true;
            this.btn_hc.Click += new System.EventHandler(this.btn_hc_Click);
            // 
            // btn_cs
            // 
            this.btn_cs.Location = new System.Drawing.Point(522, 288);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(141, 28);
            this.btn_cs.TabIndex = 4;
            this.btn_cs.Text = "Cerrar sesión";
            this.btn_cs.UseVisualStyleBackColor = true;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(178, 331);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(141, 28);
            this.btn_e.TabIndex = 5;
            this.btn_e.Text = "Editar";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_a
            // 
            this.btn_a.Location = new System.Drawing.Point(21, 331);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(141, 28);
            this.btn_a.TabIndex = 6;
            this.btn_a.Text = "Añadir";
            this.btn_a.UseVisualStyleBackColor = true;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // central_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_a);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_hc);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.btn_hi);
            this.Controls.Add(this.textBox1);
            this.Name = "central_admin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.central_admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Button btn_hc;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_a;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

