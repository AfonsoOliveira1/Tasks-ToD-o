using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksToDo
{
    public partial class TasksToDo : Form
    {
        public List<Equipas> equipas = new List<Equipas>();
        public TasksToDo()
        {
            InitializeComponent();
            EquipasComboBox();
        }

        public void EquipasComboBox()
        {
            string caminhoApp = AppDomain.CurrentDomain.BaseDirectory;
            string caminho = Path.GetPathRoot(caminhoApp) + "\\Users\\" + Environment.UserName + "\\Documents\\Ddos\\equipas.txt";
            try
            {
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
    }
}
