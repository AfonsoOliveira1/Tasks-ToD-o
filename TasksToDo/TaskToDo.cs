using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TasksToDo
{
    public partial class TasksToDo : Form
    {
        public List<Equipas> equipas = new List<Equipas>();
        public List<Funcionarios> funcionarios = new List<Funcionarios>();
        public TasksToDo()
        {
            InitializeComponent();
            FuncionariosComboBox();
            EquipasComboBox();
        }

        public void EquipasComboBox()
        {
            string caminhoApp = AppDomain.CurrentDomain.BaseDirectory;
            string caminho = Path.GetPathRoot(caminhoApp) + "\\Users\\" + Environment.UserName + "\\Documents\\Dados\\equipas.txt";
            try
            {
                cbbEquipa.Items.Clear();
                using (StreamReader leitor = new StreamReader(caminho))
                {
                    string linha;
                    while((linha = leitor.ReadLine()) != null)
                    {
                        equipas.Add(new Equipas(linha));
                        cbbEquipa.Items.Add(linha); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro com" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void FuncionariosComboBox()
        {
            string caminhoApp = AppDomain.CurrentDomain.BaseDirectory;
            string caminho = Path.GetPathRoot(caminhoApp) + "\\Users\\" + Environment.UserName + "\\Documents\\Dados\\funcionarios.txt";
            try
            {
                cbbFuncionario.Items.Clear();
                using (StreamReader leitor = new StreamReader(caminho))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        cbbFuncionario.Items.Add(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro com" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Validacao()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (!mtxtDataInicio.MaskFull)
            {
                errorProvider1.SetError(mtxtDataInicio, "Preencha a data de início!");
                valido = false;
            }
            if (!mtxtDataFim.MaskFull)
            {
                errorProvider1.SetError(mtxtDataFim, "Preencha a data de fim!");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtTarefa.Text))//mema coisa mas nao levanta exceção null
            {
                errorProvider1.SetError(txtTarefa, "Introduza o nome da tarefa!");
                valido = false;
            }
            if (cbbEquipa.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbbEquipa, "Selecione uma equipa!");
                valido = false;
            }
            if (cbbFuncionario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbbFuncionario, "Selecione um funcionário!");
                valido = false;
            }
            if (Convert.ToDateTime(mtxtDataFim.Text) < Convert.ToDateTime(mtxtDataInicio.Text))
            {
                errorProvider1.SetError(mtxtDataFim, "Data fim nao pode ser menor que a Data de incio!");
                errorProvider1.SetError(mtxtDataInicio, "Data fim nao pode ser menor que a Data de incio!");
                valido = false;
            }

            return valido;
        }

        private void AdicionarNaTreeView()
        {
            errorProvider1.Clear();

            string nomeEquipa = cbbEquipa.Text.Trim();
            string nomeFuncionario = cbbFuncionario.Text.Trim();
            string nomeTarefa = txtTarefa.Text.Trim();

            TreeNode equipaNode = null;
            foreach (TreeNode node in tvMain.Nodes)
            {
                if (node.Text == nomeEquipa)
                {
                    equipaNode = node;
                    break;
                }
            }

            if (equipaNode == null)
            {
                equipas.Add(new Equipas(cbbEquipa.Text));
                equipaNode = new TreeNode();
                equipaNode.Text = cbbEquipa.Text;
                equipaNode.ImageIndex = equipaNode.SelectedImageIndex = 0;
                tvMain.Nodes.Add(equipaNode);
            }

            TreeNode func = null;
            foreach (TreeNode node in equipaNode.Nodes)
            {
                if (node.Text == nomeFuncionario)
                {
                    func = node;
                    break;
                }
            }

            if (func == null)
            {
                var funcio = equipas[cbbEquipa.SelectedIndex].funcionarios;
                func = new TreeNode(nomeFuncionario);
                if (cbCoordenador.Checked && cbResponsavel.Checked)
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, true));
                    func.Text = "R: " + cbbFuncionario.Text;
                    func.ImageIndex = func.SelectedImageIndex = 3;
                }
                else if (cbCoordenador.Checked)
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, true));
                    func.ImageIndex = func.SelectedImageIndex = 3;
                    func.Text = cbbFuncionario.Text;
                }
                else if (cbResponsavel.Checked)
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, false));
                    func.Text = "R: " + cbbFuncionario.Text;
                    func.ImageIndex = func.SelectedImageIndex = 1;
                }
                else
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, false));
                    func.Text = cbbFuncionario.Text;
                    func.ImageIndex = func.SelectedImageIndex = 1;
                }
                equipaNode.Nodes.Add(func);
            }

            TreeNode task = null;
            foreach(TreeNode node in func.Nodes)
            {
                if(node.Text == nomeTarefa)
                {
                    task = node;
                    break;
                }
            }

            if(task == null)
            {
                var tarefa = equipas[cbbEquipa.SelectedIndex].funcionarios[cbbFuncionario.SelectedIndex].tarefas;
                string r;
                if (cbResponsavel.Checked) r = cbbFuncionario.Text; else r = "";
                tarefa.Add(new Tarefa(txtTarefa.Text, txtDescricao.Text, r, Convert.ToDateTime(mtxtDataInicio.Text), Convert.ToDateTime(mtxtDataFim.Text)));
                task = new TreeNode();
                task.Text = txtTarefa.Text;
                task.ImageIndex = task.SelectedImageIndex = 2;
                func.Nodes.Add(task);
            }
            else
            {
                errorProvider1.SetError(txtTarefa, "Já existe esta Tarefa!");
            }

            equipaNode.Expand();
            func.Expand();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!Validacao()) return;

            AdicionarNaTreeView();
        }

        private void mtxtDataInicio_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            errorProvider1.SetError(mtxtDataInicio, "");
            if (!e.IsValidInput)
            {
                errorProvider1.SetError(mtxtDataInicio, "Data inválida! Use o formato DD/MM/AAAA.");
                e.Cancel = true;
            }
        }

        private void mtxtDataFim_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            errorProvider1.SetError(mtxtDataFim, "");
            if (!e.IsValidInput)
            {
                errorProvider1.SetError(mtxtDataFim, "Data inválida! Use o formato DD/MM/AAAA.");
                e.Cancel = true;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            MessageBox.Show($"Editar: {tvMain.SelectedNode.Text}");
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            tvMain.SelectedNode.Remove();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            MessageBox.Show($"Nome: {tvMain.SelectedNode.Text}\nFuncionarios: ", "Detalhes da tarefa", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tarefasAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargaDeTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
