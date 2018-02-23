namespace View
{
    partial class Microondas
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
            this.btnNovoPrograma = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpPrograma = new System.Windows.Forms.GroupBox();
            this.txtInstrucao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaracter = new System.Windows.Forms.TextBox();
            this.caracter = new System.Windows.Forms.Label();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.tempo = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPPotencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPTempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.grpPrograma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovoPrograma
            // 
            this.btnNovoPrograma.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNovoPrograma.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNovoPrograma.Location = new System.Drawing.Point(-3, -3);
            this.btnNovoPrograma.Name = "btnNovoPrograma";
            this.btnNovoPrograma.Size = new System.Drawing.Size(312, 61);
            this.btnNovoPrograma.TabIndex = 0;
            this.btnNovoPrograma.Text = "Novo Programa";
            this.btnNovoPrograma.UseVisualStyleBackColor = false;
            this.btnNovoPrograma.Click += new System.EventHandler(this.btnNovoPrograma_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.BackColor = System.Drawing.Color.Red;
            this.btnLigar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLigar.Location = new System.Drawing.Point(308, -3);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(474, 61);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = false;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // grpPrograma
            // 
            this.grpPrograma.Controls.Add(this.txtInstrucao);
            this.grpPrograma.Controls.Add(this.label4);
            this.grpPrograma.Controls.Add(this.txtCaracter);
            this.grpPrograma.Controls.Add(this.caracter);
            this.grpPrograma.Controls.Add(this.txtPotencia);
            this.grpPrograma.Controls.Add(this.label3);
            this.grpPrograma.Controls.Add(this.txtTempo);
            this.grpPrograma.Controls.Add(this.tempo);
            this.grpPrograma.Controls.Add(this.txtChave);
            this.grpPrograma.Controls.Add(this.label2);
            this.grpPrograma.Controls.Add(this.txtNome);
            this.grpPrograma.Controls.Add(this.label1);
            this.grpPrograma.Location = new System.Drawing.Point(308, 64);
            this.grpPrograma.Name = "grpPrograma";
            this.grpPrograma.Size = new System.Drawing.Size(474, 270);
            this.grpPrograma.TabIndex = 2;
            this.grpPrograma.TabStop = false;
            this.grpPrograma.Text = "Programa";
            // 
            // txtInstrucao
            // 
            this.txtInstrucao.Location = new System.Drawing.Point(8, 115);
            this.txtInstrucao.Multiline = true;
            this.txtInstrucao.Name = "txtInstrucao";
            this.txtInstrucao.Size = new System.Drawing.Size(461, 148);
            this.txtInstrucao.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Instruções";
            // 
            // txtCaracter
            // 
            this.txtCaracter.Location = new System.Drawing.Point(322, 72);
            this.txtCaracter.Name = "txtCaracter";
            this.txtCaracter.Size = new System.Drawing.Size(147, 20);
            this.txtCaracter.TabIndex = 9;
            // 
            // caracter
            // 
            this.caracter.AutoSize = true;
            this.caracter.Location = new System.Drawing.Point(322, 56);
            this.caracter.Name = "caracter";
            this.caracter.Size = new System.Drawing.Size(47, 13);
            this.caracter.TabIndex = 8;
            this.caracter.Text = "Caracter";
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(163, 72);
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(142, 20);
            this.txtPotencia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Potencia";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(8, 72);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(142, 20);
            this.txtTempo.TabIndex = 5;
            // 
            // tempo
            // 
            this.tempo.AutoSize = true;
            this.tempo.Location = new System.Drawing.Point(8, 56);
            this.tempo.Name = "tempo";
            this.tempo.Size = new System.Drawing.Size(40, 13);
            this.tempo.TabIndex = 4;
            this.tempo.Text = "Tempo";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(293, 32);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(176, 20);
            this.txtChave.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chave:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPPotencia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPTempo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(308, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // txtPPotencia
            // 
            this.txtPPotencia.Location = new System.Drawing.Point(255, 48);
            this.txtPPotencia.Name = "txtPPotencia";
            this.txtPPotencia.Size = new System.Drawing.Size(209, 20);
            this.txtPPotencia.TabIndex = 13;
            this.txtPPotencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPPotencia_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Potencia";
            // 
            // txtPTempo
            // 
            this.txtPTempo.Location = new System.Drawing.Point(11, 48);
            this.txtPTempo.Name = "txtPTempo";
            this.txtPTempo.Size = new System.Drawing.Size(210, 20);
            this.txtPTempo.TabIndex = 7;
            this.txtPTempo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPTempo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tempo";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(312, 447);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(467, 223);
            this.txtString.TabIndex = 12;
            // 
            // Microondas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 681);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPrograma);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.btnNovoPrograma);
            this.MaximizeBox = false;
            this.Name = "Microondas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Microondas_Load);
            this.grpPrograma.ResumeLayout(false);
            this.grpPrograma.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovoPrograma;
        private System.Windows.Forms.Button btnLigar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpPrograma;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInstrucao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaracter;
        private System.Windows.Forms.Label caracter;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label tempo;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPPotencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPTempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtString;
    }
}

