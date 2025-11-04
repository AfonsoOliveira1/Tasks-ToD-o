using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TasksToDo
{
    public class Tarefa
    {
        private int t_id;
        private string t_nome;
        private string t_descricao;
        private string t_responsavel;
        private DateTime t_dataInicio;
        private DateTime t_dataFim;

        public int id { get { return t_id; } set { t_id = value; } }
        public string nome { get { return t_nome; } set { t_nome = value; } }
        public string descricao { get { return t_descricao; } set { t_descricao = value; } }
        public string responsavel { get { return t_responsavel; } set { t_responsavel = value; } }
        public DateTime dataInicio { get { return t_dataInicio;} set { t_dataInicio = value; } }
        public DateTime dataFim { get { return t_dataFim;} set {  t_dataFim = value; } }

        public Tarefa(int ID, string name, string description, string responsible, DateTime DataInicio, DateTime DataFim)
        {
            this.id = ID;
            this.nome = name;
            this.descricao = description;
            this.responsavel = responsible;
            this.dataInicio = DataInicio;
            this.dataFim = DataFim;
        }
    }
}
