namespace ChessMaster
{
    partial class FormLobby
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
            this.btnCrearLobby = new System.Windows.Forms.Button();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTituloCod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnJug2Negras = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnJug2Blancas = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblJug1 = new System.Windows.Forms.Label();
            this.rbtnJug1Negras = new System.Windows.Forms.RadioButton();
            this.rbtnBlancas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearLobby
            // 
            this.btnCrearLobby.Location = new System.Drawing.Point(6, 19);
            this.btnCrearLobby.Name = "btnCrearLobby";
            this.btnCrearLobby.Size = new System.Drawing.Size(111, 49);
            this.btnCrearLobby.TabIndex = 0;
            this.btnCrearLobby.Text = "Crear Lobby";
            this.btnCrearLobby.UseVisualStyleBackColor = true;
            this.btnCrearLobby.Click += new System.EventHandler(this.btnCrearLobby_Click);
            // 
            // btnUnirse
            // 
            this.btnUnirse.Location = new System.Drawing.Point(6, 89);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(111, 49);
            this.btnUnirse.TabIndex = 1;
            this.btnUnirse.Text = "Unirse a una Lobby";
            this.btnUnirse.UseVisualStyleBackColor = true;
            this.btnUnirse.Click += new System.EventHandler(this.btnUnirse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTituloCod);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnCrearLobby);
            this.groupBox1.Controls.Add(this.btnUnirse);
            this.groupBox1.Location = new System.Drawing.Point(80, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblTituloCod
            // 
            this.lblTituloCod.AutoSize = true;
            this.lblTituloCod.Location = new System.Drawing.Point(20, 141);
            this.lblTituloCod.Name = "lblTituloCod";
            this.lblTituloCod.Size = new System.Drawing.Size(78, 13);
            this.lblTituloCod.TabIndex = 3;
            this.lblTituloCod.Text = "Ingrese Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 38);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 106);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajedrez";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigo.Location = new System.Drawing.Point(119, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(102, 25);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "lblCodigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Location = new System.Drawing.Point(364, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crear Partida - Definir Parametros de partida";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnJug2Negras);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.rbtnJug2Blancas);
            this.groupBox4.Location = new System.Drawing.Point(195, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 127);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // rbtnJug2Negras
            // 
            this.rbtnJug2Negras.AutoSize = true;
            this.rbtnJug2Negras.Checked = true;
            this.rbtnJug2Negras.Location = new System.Drawing.Point(23, 83);
            this.rbtnJug2Negras.Name = "rbtnJug2Negras";
            this.rbtnJug2Negras.Size = new System.Drawing.Size(59, 17);
            this.rbtnJug2Negras.TabIndex = 11;
            this.rbtnJug2Negras.TabStop = true;
            this.rbtnJug2Negras.Text = "Negras";
            this.rbtnJug2Negras.UseVisualStyleBackColor = true;
            this.rbtnJug2Negras.CheckedChanged += new System.EventHandler(this.rbtnJug2Negras_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jugador 2";
            // 
            // rbtnJug2Blancas
            // 
            this.rbtnJug2Blancas.AutoSize = true;
            this.rbtnJug2Blancas.Enabled = false;
            this.rbtnJug2Blancas.Location = new System.Drawing.Point(23, 60);
            this.rbtnJug2Blancas.Name = "rbtnJug2Blancas";
            this.rbtnJug2Blancas.Size = new System.Drawing.Size(63, 17);
            this.rbtnJug2Blancas.TabIndex = 10;
            this.rbtnJug2Blancas.Text = "Blancas";
            this.rbtnJug2Blancas.UseVisualStyleBackColor = true;
            this.rbtnJug2Blancas.CheckedChanged += new System.EventHandler(this.rbtnJug2Blancas_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblJug1);
            this.groupBox3.Controls.Add(this.rbtnJug1Negras);
            this.groupBox3.Controls.Add(this.rbtnBlancas);
            this.groupBox3.Location = new System.Drawing.Point(42, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(104, 127);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // lblJug1
            // 
            this.lblJug1.AutoSize = true;
            this.lblJug1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJug1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJug1.Location = new System.Drawing.Point(6, 23);
            this.lblJug1.Name = "lblJug1";
            this.lblJug1.Size = new System.Drawing.Size(84, 20);
            this.lblJug1.TabIndex = 7;
            this.lblJug1.Text = "Jugador1";
            // 
            // rbtnJug1Negras
            // 
            this.rbtnJug1Negras.AutoSize = true;
            this.rbtnJug1Negras.Enabled = false;
            this.rbtnJug1Negras.Location = new System.Drawing.Point(10, 83);
            this.rbtnJug1Negras.Name = "rbtnJug1Negras";
            this.rbtnJug1Negras.Size = new System.Drawing.Size(59, 17);
            this.rbtnJug1Negras.TabIndex = 9;
            this.rbtnJug1Negras.Text = "Negras";
            this.rbtnJug1Negras.UseVisualStyleBackColor = true;
            this.rbtnJug1Negras.CheckedChanged += new System.EventHandler(this.rbtnJug1Negras_CheckedChanged);
            // 
            // rbtnBlancas
            // 
            this.rbtnBlancas.AutoSize = true;
            this.rbtnBlancas.Checked = true;
            this.rbtnBlancas.Enabled = false;
            this.rbtnBlancas.Location = new System.Drawing.Point(10, 60);
            this.rbtnBlancas.Name = "rbtnBlancas";
            this.rbtnBlancas.Size = new System.Drawing.Size(63, 17);
            this.rbtnBlancas.TabIndex = 6;
            this.rbtnBlancas.TabStop = true;
            this.rbtnBlancas.Text = "Blancas";
            this.rbtnBlancas.UseVisualStyleBackColor = true;
            this.rbtnBlancas.CheckedChanged += new System.EventHandler(this.rbtnBlancas_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo:";
            // 
            // FormLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLobby";
            this.Text = "FormLobby";
            this.Load += new System.EventHandler(this.FormLobby_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearLobby;
        private System.Windows.Forms.Button btnUnirse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTituloCod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnBlancas;
        private System.Windows.Forms.RadioButton rbtnJug2Negras;
        private System.Windows.Forms.RadioButton rbtnJug2Blancas;
        private System.Windows.Forms.RadioButton rbtnJug1Negras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJug1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}