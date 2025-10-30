namespace TasksToDo
{
    partial class TasksToDo
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
            this.cbbEquipa = new System.Windows.Forms.ComboBox();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblEquipa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.cbCoordenador = new System.Windows.Forms.CheckBox();
            this.cbResponsavel = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbEquipa
            // 
            this.cbbEquipa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEquipa.FormattingEnabled = true;
            this.cbbEquipa.Location = new System.Drawing.Point(377, 150);
            this.cbbEquipa.Name = "cbbEquipa";
            this.cbbEquipa.Size = new System.Drawing.Size(121, 24);
            this.cbbEquipa.TabIndex = 0;
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(244, 150);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(121, 24);
            this.cbbFuncionario.TabIndex = 1;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(241, 131);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(77, 16);
            this.lblFuncionario.TabIndex = 2;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // lblEquipa
            // 
            this.lblEquipa.AutoSize = true;
            this.lblEquipa.Location = new System.Drawing.Point(374, 131);
            this.lblEquipa.Name = "lblEquipa";
            this.lblEquipa.Size = new System.Drawing.Size(50, 16);
            this.lblEquipa.TabIndex = 3;
            this.lblEquipa.Text = "Equipa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblDataFim);
            this.panel1.Controls.Add(this.lblDataInicio);
            this.panel1.Controls.Add(this.maskedTextBox2);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.cbResponsavel);
            this.panel1.Controls.Add(this.cbCoordenador);
            this.panel1.Controls.Add(this.txtTarefa);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblEquipa);
            this.panel1.Controls.Add(this.cbbEquipa);
            this.panel1.Controls.Add(this.lblFuncionario);
            this.panel1.Controls.Add(this.cbbFuncionario);
            this.panel1.Location = new System.Drawing.Point(42, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 380);
            this.panel1.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(241, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(106, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome da Tarefa";
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(244, 39);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(254, 22);
            this.txtTarefa.TabIndex = 5;
            // 
            // cbCoordenador
            // 
            this.cbCoordenador.AutoSize = true;
            this.cbCoordenador.Location = new System.Drawing.Point(543, 41);
            this.cbCoordenador.Name = "cbCoordenador";
            this.cbCoordenador.Size = new System.Drawing.Size(109, 20);
            this.cbCoordenador.TabIndex = 6;
            this.cbCoordenador.Text = "Coordenador";
            this.cbCoordenador.UseVisualStyleBackColor = true;
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.AutoSize = true;
            this.cbResponsavel.Location = new System.Drawing.Point(543, 67);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(110, 20);
            this.cbResponsavel.TabIndex = 7;
            this.cbResponsavel.Text = "Responsável";
            this.cbResponsavel.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(349, 95);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 22);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(244, 95);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(82, 22);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(241, 76);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(89, 16);
            this.lblDataInicio.TabIndex = 10;
            this.lblDataInicio.Text = "Data de Início";
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(346, 76);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(80, 16);
            this.lblDataFim.TabIndex = 11;
            this.lblDataFim.Text = "Data de Fim";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(408, 111);
            this.textBox1.TabIndex = 12;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(241, 197);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 16);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            this.tvMain.Size = new System.Drawing.Size(217, 380);
            this.tvMain.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 380);
            this.panel2.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(243, 333);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(181, 33);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(471, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(181, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // TasksToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "TasksToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks To Do";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbEquipa;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblEquipa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataFim;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.CheckBox cbResponsavel;
        private System.Windows.Forms.CheckBox cbCoordenador;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox textBox1;
    }
}

