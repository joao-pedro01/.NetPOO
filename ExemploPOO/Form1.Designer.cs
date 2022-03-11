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
            this.pnProfessor = new System.Windows.Forms.Panel();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.pnPessoa = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.pnPessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // pnAluno
            // 
            this.pnAluno.Location = new System.Drawing.Point(272, 12);
            this.pnAluno.Name = "pnAluno";
            this.pnAluno.Size = new System.Drawing.Size(249, 353);
            this.pnAluno.TabIndex = 9;
            // 
            // pnProfessor
            // 
            this.pnProfessor.Location = new System.Drawing.Point(527, 12);
            this.pnProfessor.Name = "pnProfessor";
            this.pnProfessor.Size = new System.Drawing.Size(252, 353);
            this.pnProfessor.TabIndex = 10;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(86, 68);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 23);
            this.txtRg.TabIndex = 5;
            this.txtRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 7;
            // 
            // pnPessoa
            // 
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
            this.pnPessoa.Size = new System.Drawing.Size(273, 353);
            this.pnPessoa.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(98, 202);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "button1";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cpf";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "rg";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 150);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(86, 107);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 23);
            this.txtCpf.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 509);
            this.Controls.Add(this.pnProfessor);
            this.Controls.Add(this.pnAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnPessoa);
            this.Name = "Form1";
            this.Text = "Exemplo POO";
            this.Load += new System.EventHandler(this.Forms1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.pnPessoa.ResumeLayout(false);
            this.pnPessoa.PerformLayout();
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
    }
}