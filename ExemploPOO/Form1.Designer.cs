namespace ExemploPOO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnAluno = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnProfessor = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.pnPessoa = new System.Windows.Forms.Panel();
            this.painel = new System.Windows.Forms.GroupBox();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnAluno.SuspendLayout();
            this.pnProfessor.SuspendLayout();
            this.pnPessoa.SuspendLayout();
            this.painel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pnAluno
            // 
            this.pnAluno.Controls.Add(this.label9);
            this.pnAluno.Controls.Add(this.label10);
            this.pnAluno.Controls.Add(this.maskedTextBox1);
            this.pnAluno.Controls.Add(this.maskedTextBox2);
            this.pnAluno.Controls.Add(this.label7);
            this.pnAluno.Location = new System.Drawing.Point(272, 12);
            this.pnAluno.Name = "pnAluno";
            this.pnAluno.Size = new System.Drawing.Size(249, 353);
            this.pnAluno.TabIndex = 9;
            this.pnAluno.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Curso";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "RA";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 43);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 18;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(90, 84);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(75, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "Aluno";
            // 
            // pnProfessor
            // 
            this.pnProfessor.Controls.Add(this.label11);
            this.pnProfessor.Controls.Add(this.label12);
            this.pnProfessor.Controls.Add(this.maskedTextBox3);
            this.pnProfessor.Controls.Add(this.maskedTextBox4);
            this.pnProfessor.Controls.Add(this.label8);
            this.pnProfessor.Location = new System.Drawing.Point(527, 12);
            this.pnProfessor.Name = "pnProfessor";
            this.pnProfessor.Size = new System.Drawing.Size(252, 353);
            this.pnProfessor.TabIndex = 10;
            this.pnProfessor.Visible = false;
            this.pnProfessor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnProfessor_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Formação";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "RP";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(100, 40);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox3.TabIndex = 15;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(100, 81);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox4.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(59, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Professor";
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(104, 84);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 23);
            this.txtRg.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // pnPessoa
            // 
            this.pnPessoa.Controls.Add(this.painel);
            this.pnPessoa.Controls.Add(this.label6);
            this.pnPessoa.Controls.Add(this.btnEnviar);
            this.pnPessoa.Controls.Add(this.label5);
            this.pnPessoa.Controls.Add(this.label4);
            this.pnPessoa.Controls.Add(this.label3);
            this.pnPessoa.Controls.Add(this.label2);
            this.pnPessoa.Controls.Add(this.txtEmail);
            this.pnPessoa.Controls.Add(this.txtCpf);
            this.pnPessoa.Controls.Add(this.txtNome);
            this.pnPessoa.Controls.Add(this.txtRg);
            this.pnPessoa.Location = new System.Drawing.Point(2, 12);
            this.pnPessoa.Name = "pnPessoa";
            this.pnPessoa.Size = new System.Drawing.Size(273, 423);
            this.pnPessoa.TabIndex = 8;
            // 
            // painel
            // 
            this.painel.Controls.Add(this.rbProfessor);
            this.painel.Controls.Add(this.rbAluno);
            this.painel.Location = new System.Drawing.Point(41, 265);
            this.painel.Name = "painel";
            this.painel.Size = new System.Drawing.Size(200, 100);
            this.painel.TabIndex = 17;
            this.painel.TabStop = false;
            this.painel.Tag = "";
            this.painel.Text = "Tipo de Pessoa";
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Location = new System.Drawing.Point(6, 47);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(74, 19);
            this.rbProfessor.TabIndex = 20;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            this.rbProfessor.CheckedChanged += new System.EventHandler(this.rbProfessor_CheckedChanged);
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(6, 22);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(57, 19);
            this.rbAluno.TabIndex = 20;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            this.rbAluno.CheckedChanged += new System.EventHandler(this.rbAluno_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(107, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pessoa";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(116, 218);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(104, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(104, 123);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(988, 509);
            this.Controls.Add(this.pnProfessor);
            this.Controls.Add(this.pnAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnPessoa);
            this.Name = "Form1";
            this.Text = "Exemplo POO";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnAluno.ResumeLayout(false);
            this.pnAluno.PerformLayout();
            this.pnProfessor.ResumeLayout(false);
            this.pnProfessor.PerformLayout();
            this.pnPessoa.ResumeLayout(false);
            this.pnPessoa.PerformLayout();
            this.painel.ResumeLayout(false);
            this.painel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NotifyIcon notifyIcon1;
        private BindingSource bindingSource1;
        private Panel pnAluno;
        private Panel pnProfessor;
        private MaskedTextBox txtRg;
        private Label label1;
        private MaskedTextBox txtNome;
        private Panel pnPessoa;
        private MaskedTextBox txtEmail;
        private MaskedTextBox txtCpf;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Button btnEnviar;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label11;
        private Label label12;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private GroupBox painel;
        private RadioButton rbProfessor;
        private RadioButton rbAluno;
    }
}