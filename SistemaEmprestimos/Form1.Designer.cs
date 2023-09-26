namespace SistemaEmprestimos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmprestimosID = new System.Windows.Forms.TextBox();
            this.txtLivroID = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.dtnDataEmprestimos = new System.Windows.Forms.TextBox();
            this.dtnEmprestimos = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConferir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmprestimosID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LivroID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ClienteID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DataEmprestimos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DataDevolucao";
            // 
            // txtEmprestimosID
            // 
            this.txtEmprestimosID.Location = new System.Drawing.Point(12, 25);
            this.txtEmprestimosID.Name = "txtEmprestimosID";
            this.txtEmprestimosID.Size = new System.Drawing.Size(153, 20);
            this.txtEmprestimosID.TabIndex = 5;
            // 
            // txtLivroID
            // 
            this.txtLivroID.Location = new System.Drawing.Point(12, 107);
            this.txtLivroID.Name = "txtLivroID";
            this.txtLivroID.Size = new System.Drawing.Size(153, 20);
            this.txtLivroID.TabIndex = 6;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(12, 182);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(153, 20);
            this.txtClienteID.TabIndex = 7;
            // 
            // dtnDataEmprestimos
            // 
            this.dtnDataEmprestimos.Location = new System.Drawing.Point(12, 268);
            this.dtnDataEmprestimos.Name = "dtnDataEmprestimos";
            this.dtnDataEmprestimos.Size = new System.Drawing.Size(153, 20);
            this.dtnDataEmprestimos.TabIndex = 8;
            // 
            // dtnEmprestimos
            // 
            this.dtnEmprestimos.Location = new System.Drawing.Point(12, 357);
            this.dtnEmprestimos.Name = "dtnEmprestimos";
            this.dtnEmprestimos.Size = new System.Drawing.Size(153, 20);
            this.dtnEmprestimos.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(383, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnConferir
            // 
            this.btnConferir.Location = new System.Drawing.Point(713, 415);
            this.btnConferir.Name = "btnConferir";
            this.btnConferir.Size = new System.Drawing.Size(75, 23);
            this.btnConferir.TabIndex = 11;
            this.btnConferir.Text = "Confeir";
            this.btnConferir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(383, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 358);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConferir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtnEmprestimos);
            this.Controls.Add(this.dtnDataEmprestimos);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.txtLivroID);
            this.Controls.Add(this.txtEmprestimosID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SistemaEmprestimos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmprestimosID;
        private System.Windows.Forms.TextBox txtLivroID;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox dtnDataEmprestimos;
        private System.Windows.Forms.TextBox dtnEmprestimos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConferir;
        private System.Windows.Forms.Panel panel1;
    }
}

