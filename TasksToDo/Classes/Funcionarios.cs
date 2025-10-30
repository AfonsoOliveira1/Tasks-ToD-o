using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksToDo
{
    public class Funcionarios
    {
        private string f_nome;
        private bool f_coordenador;
        public string nome { get { return f_nome; } set { f_nome = value; } }
        public bool coordenador { get { return f_coordenador; } set { f_coordenador = value; } }
        public List<Tarefa> tarefas { get; set; }
        public Funcionarios(string name, bool Coordenador)
        {
            this.nome = name;
            this.coordenador = Coordenador;
            tarefas = new List<Tarefa>();
        }
    }
}
