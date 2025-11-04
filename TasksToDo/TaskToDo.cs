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
using System.Xml.Linq;
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
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pastaDocumentos, "Dados", "equipas.txt");
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
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pastaDocumentos, "Dados", "funcionarios.txt");
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
                return false;
            }
            if (!mtxtDataFim.MaskFull)
            {
                errorProvider1.SetError(mtxtDataFim, "Preencha a data de fim!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTarefa.Text))//mema coisa mas nao levanta exceção null
            {
                errorProvider1.SetError(txtTarefa, "Introduza o nome da tarefa!");
                return false;
            }
            if (cbbEquipa.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbbEquipa, "Selecione uma equipa!");
                return false;
            }
            if (cbbFuncionario.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbbFuncionario, "Selecione um funcionário!");
                return false;
            }
            if (Convert.ToDateTime(mtxtDataFim.Text) < Convert.ToDateTime(mtxtDataInicio.Text))
            {
                errorProvider1.SetError(mtxtDataFim, "Data fim nao pode ser menor que a Data de incio!");
                errorProvider1.SetError(mtxtDataInicio, "Data fim nao pode ser menor que a Data de incio!");
                valido = false;
            }
            if (equipas[cbbEquipa.SelectedIndex].funcionarios.Count >= 5)//cada equipa so pode ter 5 funcionarios no maximo
            {
                valido = false;
                errorProvider1.SetError(cbbFuncionario, "Cada equipa só pode ter 5 funcionarios no maximo");
            }

            var funcionario = equipas
                .SelectMany(e => e.funcionarios)
                .FirstOrDefault(x => x.nome == cbbFuncionario.Text);

            if (funcionario == null)
            {
                valido = true;
            }
            else if (funcionario.tarefas.Count >= 3)//cada funcionario so pode ter 3 tarefas
            {
                valido = false;
                errorProvider1.SetError(txtTarefa, "O funcionario so pode ter 3 tarefas");
            }

            var Coordenador = equipas[cbbEquipa.SelectedIndex].funcionarios.FirstOrDefault(x => x.coordenador == true);
            
            if(Coordenador != null && cbCoordenador.Checked)//so pode haver 1 coordenador por equipa
            {
                valido = false;
                errorProvider1.SetError(cbCoordenador, "Já existe coordenador para esta equipa!");
            }

            var responsaveis = equipas[cbbEquipa.SelectedIndex].funcionarios.SelectMany(f => f.tarefas).Where(t => t.responsavel != "" && t.nome == txtTarefa.Text).ToList();
            if(responsaveis.Count >= 1 && cbResponsavel.Checked)//so pode haver 1 responsavel por tarefa
            {
                valido = false;
                errorProvider1.SetError(cbResponsavel, "Só pode haver 1 responsavel por tarefa");
            }

            return valido;
        }

        private void AdicionarNaTreeView()
        {
            errorProvider1.Clear();

            string nomeEquipa = cbbEquipa.Text;
            string nomeFuncionario = cbbFuncionario.Text;
            string nomeTarefa = txtTarefa.Text;

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
                func.Tag = cbbFuncionario.Text;

                if (cbCoordenador.Checked)
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, true));
                    func.ImageIndex = func.SelectedImageIndex = 3;
                }
                else
                {
                    funcio.Add(new Funcionarios(cbbFuncionario.Text, false));
                    func.ImageIndex = func.SelectedImageIndex = 1;
                }
                equipaNode.Nodes.Add(func);
            }

            TreeNode task = null;
            foreach(TreeNode node in func.Nodes)
            {
                if(node.Tag.ToString() == nomeTarefa)
                {
                    task = node;
                    break;
                }
            }

            if(task == null)
            {
                var tarefa = equipas.SelectMany(e => e.funcionarios).FirstOrDefault(x => x.nome == nomeFuncionario).tarefas;
                if (cbResponsavel.Checked)
                {
                    task = new TreeNode(nomeTarefa);
                    tarefa.Add(new Tarefa(nomeTarefa, txtDescricao.Text, func.Text, Convert.ToDateTime(mtxtDataInicio.Text), Convert.ToDateTime(mtxtDataFim.Text)));
                    task.Text = nomeTarefa + $" R: {func.Text}";
                    task.Tag = nomeTarefa;
                    task.ImageIndex = task.SelectedImageIndex = 2;
                }
                else
                {
                    var findTaskResponsible = equipas.SelectMany(e => e.funcionarios).SelectMany(f => f.tarefas).FirstOrDefault(x => x.nome == nomeTarefa);
                    if (findTaskResponsible != null)
                    {
                        task = new TreeNode(nomeTarefa + $" R: {findTaskResponsible.responsavel}");
                        tarefa.Add(new Tarefa(nomeTarefa, txtDescricao.Text, findTaskResponsible.responsavel, Convert.ToDateTime(mtxtDataInicio.Text), Convert.ToDateTime(mtxtDataFim.Text)));
                    }
                    else
                    {
                        task = new TreeNode(nomeTarefa);
                        tarefa.Add(new Tarefa(nomeTarefa, txtDescricao.Text, "", Convert.ToDateTime(mtxtDataInicio.Text), Convert.ToDateTime(mtxtDataFim.Text)));
                    }
                    task.Tag = nomeTarefa;
                    task.ImageIndex = task.SelectedImageIndex = 2;
                }
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
            string pastaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string caminho = Path.Combine(pastaDocumentos, "Dados", "treeviewdados.txt");
            try
            {
                File.WriteAllText(caminho, string.Empty);
                using (StreamWriter writer = new StreamWriter(caminho))
                {
                    for (int i = 0; i < equipas.Count; i++)
                    {
                        writer.Write(equipas[i].nome);
                        for(int j = 0; j < equipas[i].funcionarios.Count; j++)
                        {
                            writer.Write("|" + equipas[i].funcionarios[j].nome);
                            for(int l = 0; l < equipas[i].funcionarios[j].tarefas.Count; l++)
                            {
                                writer.Write("|" + equipas[i].funcionarios[j].tarefas[l].nome);
                            }

                        }
                        writer.WriteLine("\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro com" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            TreeNode node = tvMain.SelectedNode;
            switch (node.Level)
            {
                case 2: //tasks
                    var funcionario = equipas[node.Parent.Parent.Index].funcionarios[node.Parent.Index];
                    var findtask = funcionario.tarefas.FirstOrDefault(x => x.nome == node.Tag.ToString());
                    txtTarefa.Text = findtask.nome;
                    mtxtDataInicio.Text = findtask.dataInicio.ToString("dd/MM/yyyy");
                    mtxtDataFim.Text = findtask.dataFim.ToString("dd/MM/yyyy");
                    cbResponsavel.Checked = findtask.responsavel != "";
                    cbCoordenador.Checked = funcionario.coordenador;
                    cbbEquipa.SelectedIndex = node.Parent.Parent.Index;
                    cbbFuncionario.SelectedIndex = node.Parent.Index;
                    break;
            }
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            TreeNode node = tvMain.SelectedNode;
            switch (node.Level)
            {
                case 0: //equipa
                    var findequipa = equipas.FirstOrDefault(x => x.nome == node.Text);
                    equipas.Remove(findequipa);
                    break;
                case 1: //func
                    var findfunc = equipas.SelectMany(f => f.funcionarios).FirstOrDefault(x => x.nome == node.Text);
                    equipas[node.Parent.Index].funcionarios.Remove(findfunc);
                    break;
                case 2: //tasks
                    var findtask = equipas.SelectMany(f => f.funcionarios).SelectMany(t => t.tarefas).FirstOrDefault(x => x.nome == node.Tag.ToString());
                    equipas[node.Parent.Parent.Index].funcionarios[node.Parent.Index].tarefas.Remove(findtask);
                    break;
            }
            tvMain.SelectedNode.Remove();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            TreeNode node = tvMain.SelectedNode;

            switch (node.Level)
            { 
                case 2: //tasks
                    var tarefa = equipas
                        .SelectMany(eq => eq.funcionarios)
                        .SelectMany(func => func.tarefas)
                        .FirstOrDefault(t => t.nome == node.Tag.ToString());

                    if (tarefa != null)
                    {
                        string mensagem =
                                $"Nome: {tarefa.nome}\n" +
                                $"Data de Início: {tarefa.dataInicio:dd/MM/yyyy}\n" +
                                $"Data de Fim: {tarefa.dataFim:dd/MM/yyyy}\n" +
                                $"Descrição: {tarefa.descricao}\n" +
                                $"Responsável: {tarefa.responsavel}\n";

                        List<string> mensagemPartes = new List<string>();
                        for(int i = 0; i < equipas.Count; i++)
                        {
                            var eq = equipas[i];
                            for(int j = 0; j < eq.funcionarios.Count; j++)
                            {
                                var func = eq.funcionarios[j];
                                for(int l = 0; l < func.tarefas.Count; l++)
                                {
                                    var task = func.tarefas[l];
                                    if(task.nome == tarefa.nome)
                                    {
                                        mensagemPartes.Add($"Equipa: {eq.nome}\n");
                                        mensagemPartes.Add($"Funcionário: {func.nome}\n");
                                    }
                                }
                            }
                        }
                        
                    MessageBox.Show(mensagem + string.Join("", mensagemPartes), "Detalhes da Tarefa",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void tarefasAtivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tvMain.SelectedNode == null) return;
            TreeNode node = tvMain.SelectedNode;

            switch (node.Level)
            {
                case 1: //func
                    var equipa = equipas[node.Parent.Parent.Index];
                    var funcionario = equipa.funcionarios[node.Parent.Index];
                    var tarefa = funcionario.tarefas.FirstOrDefault(t => t.nome == node.Tag.ToString());

                    if (tarefa != null)
                    {
                        string mensagem =
                            $"Nome: {tarefa.nome}\n" +
                            $"Data de Início: {tarefa.dataInicio:dd/MM/yyyy}\n" +
                            $"Data de Fim: {tarefa.dataFim:dd/MM/yyyy}\n" +
                            $"Descrição: {tarefa.descricao}\n" +
                            $"Responsável: {tarefa.responsavel}\n" +
                            $"Equipa: {equipa.nome}" +
                            $"Funcionário: {funcionario.nome}\n";

                        MessageBox.Show(mensagem, "Detalhes da Tarefa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                    break;
            }
        }       

        private void cargaDeTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void desempenhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
