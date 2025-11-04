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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksToDo));
            this.cbbEquipa = new System.Windows.Forms.ComboBox();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblEquipa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalhesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasAtivasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeTrabalhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desempenhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDataFim = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.mtxtDataInicio = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataFim = new System.Windows.Forms.MaskedTextBox();
            this.cbResponsavel = new System.Windows.Forms.CheckBox();
            this.cbCoordenador = new System.Windows.Forms.CheckBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbEquipa
            // 
            this.cbbEquipa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEquipa.FormattingEnabled = true;
            this.cbbEquipa.Location = new System.Drawing.Point(367, 121);
            this.cbbEquipa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbEquipa.Name = "cbbEquipa";
            this.cbbEquipa.Size = new System.Drawing.Size(92, 21);
            this.cbbEquipa.TabIndex = 0;
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(251, 121);
            this.cbbFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(92, 21);
            this.cbbFuncionario.TabIndex = 1;
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(248, 106);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(62, 13);
            this.lblFuncionario.TabIndex = 2;
            this.lblFuncionario.Text = "Funcionario";
            // 
            // lblEquipa
            // 
            this.lblEquipa.AutoSize = true;
            this.lblEquipa.Location = new System.Drawing.Point(364, 105);
            this.lblEquipa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipa.Name = "lblEquipa";
            this.lblEquipa.Size = new System.Drawing.Size(40, 13);
            this.lblEquipa.TabIndex = 3;
            this.lblEquipa.Text = "Equipa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.lblDataFim);
            this.panel1.Controls.Add(this.lblDataInicio);
            this.panel1.Controls.Add(this.mtxtDataInicio);
            this.panel1.Controls.Add(this.mtxtDataFim);
            this.panel1.Controls.Add(this.cbResponsavel);
            this.panel1.Controls.Add(this.cbCoordenador);
            this.panel1.Controls.Add(this.txtTarefa);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblEquipa);
            this.panel1.Controls.Add(this.cbbEquipa);
            this.panel1.Controls.Add(this.lblFuncionario);
            this.panel1.Controls.Add(this.cbbFuncionario);
            this.panel1.Location = new System.Drawing.Point(28, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 354);
            this.panel1.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(474, 314);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 27);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdicionar.Location = new System.Drawing.Point(250, 314);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(136, 27);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 354);
            this.panel2.TabIndex = 5;
            // 
            // tvMain
            // 
            this.tvMain.BackColor = System.Drawing.SystemColors.Window;
            this.tvMain.ContextMenuStrip = this.contextMenuStrip1;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.imageList1;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Margin = new System.Windows.Forms.Padding(2);
            this.tvMain.Name = "tvMain";
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(233, 354);
            this.tvMain.TabIndex = 14;
            this.tvMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMain_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.detalhesToolStripMenuItem,
            this.tarefasAtivasToolStripMenuItem,
            this.cargaDeTrabalhoToolStripMenuItem,
            this.desempenhoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 136);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            // 
            // detalhesToolStripMenuItem
            // 
            this.detalhesToolStripMenuItem.Name = "detalhesToolStripMenuItem";
            this.detalhesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.detalhesToolStripMenuItem.Text = "Detalhes";
            this.detalhesToolStripMenuItem.Click += new System.EventHandler(this.detalhesToolStripMenuItem_Click);
            // 
            // tarefasAtivasToolStripMenuItem
            // 
            this.tarefasAtivasToolStripMenuItem.Name = "tarefasAtivasToolStripMenuItem";
            this.tarefasAtivasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tarefasAtivasToolStripMenuItem.Text = "Tarefas Ativas";
            this.tarefasAtivasToolStripMenuItem.Click += new System.EventHandler(this.tarefasAtivasToolStripMenuItem_Click);
            // 
            // cargaDeTrabalhoToolStripMenuItem
            // 
            this.cargaDeTrabalhoToolStripMenuItem.Name = "cargaDeTrabalhoToolStripMenuItem";
            this.cargaDeTrabalhoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.cargaDeTrabalhoToolStripMenuItem.Text = "Carga de trabalho";
            this.cargaDeTrabalhoToolStripMenuItem.Click += new System.EventHandler(this.cargaDeTrabalhoToolStripMenuItem_Click);
            // 
            // desempenhoToolStripMenuItem
            // 
            this.desempenhoToolStripMenuItem.Name = "desempenhoToolStripMenuItem";
            this.desempenhoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.desempenhoToolStripMenuItem.Text = "Desempenho";
            this.desempenhoToolStripMenuItem.Click += new System.EventHandler(this.desempenhoToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "team.png");
            this.imageList1.Images.SetKeyName(1, "employee.png");
            this.imageList1.Images.SetKeyName(2, "task.jpg");
            this.imageList1.Images.SetKeyName(3, "coordinator.jpg");
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(248, 153);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(251, 168);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(359, 142);
            this.txtDescricao.TabIndex = 12;
            // 
            // lblDataFim
            // 
            this.lblDataFim.AutoSize = true;
            this.lblDataFim.Location = new System.Drawing.Point(364, 61);
            this.lblDataFim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFim.Name = "lblDataFim";
            this.lblDataFim.Size = new System.Drawing.Size(64, 13);
            this.lblDataFim.TabIndex = 11;
            this.lblDataFim.Text = "Data de Fim";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(248, 62);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(75, 13);
            this.lblDataInicio.TabIndex = 10;
            this.lblDataInicio.Text = "Data de Início";
            // 
            // mtxtDataInicio
            // 
            this.mtxtDataInicio.Location = new System.Drawing.Point(251, 77);
            this.mtxtDataInicio.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDataInicio.Mask = "00/00/0000";
            this.mtxtDataInicio.Name = "mtxtDataInicio";
            this.mtxtDataInicio.Size = new System.Drawing.Size(73, 20);
            this.mtxtDataInicio.TabIndex = 9;
            this.mtxtDataInicio.ValidatingType = typeof(System.DateTime);
            this.mtxtDataInicio.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDataInicio_TypeValidationCompleted);
            // 
            // mtxtDataFim
            // 
            this.mtxtDataFim.Location = new System.Drawing.Point(367, 76);
            this.mtxtDataFim.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtDataFim.Mask = "00/00/0000";
            this.mtxtDataFim.Name = "mtxtDataFim";
            this.mtxtDataFim.Size = new System.Drawing.Size(73, 20);
            this.mtxtDataFim.TabIndex = 8;
            this.mtxtDataFim.ValidatingType = typeof(System.DateTime);
            this.mtxtDataFim.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDataFim_TypeValidationCompleted);
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.AutoSize = true;
            this.cbResponsavel.Location = new System.Drawing.Point(495, 54);
            this.cbResponsavel.Margin = new System.Windows.Forms.Padding(2);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(88, 17);
            this.cbResponsavel.TabIndex = 7;
            this.cbResponsavel.Text = "Responsável";
            this.cbResponsavel.UseVisualStyleBackColor = true;
            // 
            // cbCoordenador
            // 
            this.cbCoordenador.AutoSize = true;
            this.cbCoordenador.Location = new System.Drawing.Point(495, 33);
            this.cbCoordenador.Margin = new System.Windows.Forms.Padding(2);
            this.cbCoordenador.Name = "cbCoordenador";
            this.cbCoordenador.Size = new System.Drawing.Size(87, 17);
            this.cbCoordenador.TabIndex = 6;
            this.cbCoordenador.Text = "Coordenador";
            this.cbCoordenador.UseVisualStyleBackColor = true;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(251, 31);
            this.txtTarefa.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarefa.MaxLength = 30;
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(208, 20);
            this.txtTarefa.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(248, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(84, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome da Tarefa";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TasksToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(688, 393);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "TasksToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks To Do";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox mtxtDataInicio;
        private System.Windows.Forms.MaskedTextBox mtxtDataFim;
        private System.Windows.Forms.CheckBox cbResponsavel;
        private System.Windows.Forms.CheckBox cbCoordenador;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalhesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefasAtivasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeTrabalhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desempenhoToolStripMenuItem;
    }
}

