namespace ChessMaster
{
    partial class Form3
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
            this.pbTorre = new System.Windows.Forms.PictureBox();
            this.pbCaballo = new System.Windows.Forms.PictureBox();
            this.pbReina = new System.Windows.Forms.PictureBox();
            this.pbAlfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTorre
            // 
            this.pbTorre.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pbTorre.BackColor = System.Drawing.Color.Silver;
            this.pbTorre.Location = new System.Drawing.Point(250, 169);
            this.pbTorre.Name = "pbTorre";
            this.pbTorre.Size = new System.Drawing.Size(112, 118);
            this.pbTorre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTorre.TabIndex = 3;
            this.pbTorre.TabStop = false;
            this.pbTorre.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbCaballo
            // 
            this.pbCaballo.BackColor = System.Drawing.Color.Silver;
            this.pbCaballo.Location = new System.Drawing.Point(81, 22);
            this.pbCaballo.Name = "pbCaballo";
            this.pbCaballo.Size = new System.Drawing.Size(112, 118);
            this.pbCaballo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaballo.TabIndex = 2;
            this.pbCaballo.TabStop = false;
            this.pbCaballo.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbReina
            // 
            this.pbReina.BackColor = System.Drawing.Color.Silver;
            this.pbReina.Location = new System.Drawing.Point(250, 22);
            this.pbReina.Name = "pbReina";
            this.pbReina.Size = new System.Drawing.Size(112, 118);
            this.pbReina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReina.TabIndex = 1;
            this.pbReina.TabStop = false;
            this.pbReina.Click += new System.EventHandler(this.pb_Click);
            // 
            // pbAlfil
            // 
            this.pbAlfil.BackColor = System.Drawing.Color.Silver;
            this.pbAlfil.Location = new System.Drawing.Point(81, 169);
            this.pbAlfil.Name = "pbAlfil";
            this.pbAlfil.Size = new System.Drawing.Size(112, 118);
            this.pbAlfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAlfil.TabIndex = 0;
            this.pbAlfil.TabStop = false;
            this.pbAlfil.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(451, 299);
            this.Controls.Add(this.pbTorre);
            this.Controls.Add(this.pbCaballo);
            this.Controls.Add(this.pbReina);
            this.Controls.Add(this.pbAlfil);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTorre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaballo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAlfil;
        private System.Windows.Forms.PictureBox pbReina;
        private System.Windows.Forms.PictureBox pbCaballo;
        private System.Windows.Forms.PictureBox pbTorre;
    }
}