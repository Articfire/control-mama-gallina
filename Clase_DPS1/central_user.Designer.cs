namespace Clase_DPS1
{
    partial class central_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(central_user));
            this.btn_hc = new System.Windows.Forms.Button();
            this.btn_cd = new System.Windows.Forms.Button();
            this.btn_hi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hc
            // 
            this.btn_hc.Location = new System.Drawing.Point(523, 221);
            this.btn_hc.Name = "btn_hc";
            this.btn_hc.Size = new System.Drawing.Size(141, 28);
            this.btn_hc.TabIndex = 11;
            this.btn_hc.Text = "Historial de corte";
            this.btn_hc.UseVisualStyleBackColor = true;
            this.btn_hc.Click += new System.EventHandler(this.btn_hc_Click);
            // 
            // btn_cd
            // 
            this.btn_cd.Location = new System.Drawing.Point(523, 159);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(141, 28);
            this.btn_cd.TabIndex = 10;
            this.btn_cd.Text = "Corte diario";
            this.btn_cd.UseVisualStyleBackColor = true;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // btn_hi
            // 
            this.btn_hi.Location = new System.Drawing.Point(523, 99);
            this.btn_hi.Name = "btn_hi";
            this.btn_hi.Size = new System.Drawing.Size(141, 28);
            this.btn_hi.TabIndex = 9;
            this.btn_hi.Text = "Registro Inventario";
            this.btn_hi.UseVisualStyleBackColor = true;
            this.btn_hi.Click += new System.EventHandler(this.btn_hi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(477, 213);
            this.textBox1.TabIndex = 8;
            // 
            // btn_cs
            // 
            this.btn_cs.Location = new System.Drawing.Point(523, 284);
            this.btn_cs.Name = "btn_cs";
            this.btn_cs.Size = new System.Drawing.Size(141, 28);
            this.btn_cs.TabIndex = 12;
            this.btn_cs.Text = "Cerrar sesión";
            this.btn_cs.UseVisualStyleBackColor = true;
            this.btn_cs.Click += new System.EventHandler(this.btn_cs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 81);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // central_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 354);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cs);
            this.Controls.Add(this.btn_hc);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.btn_hi);
            this.Controls.Add(this.textBox1);
            this.Name = "central_user";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_hc;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Button btn_hi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_cs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}