using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksToDo
{
    public class Equipas
    {
        private string e_nome;
        public List<Funcionarios> funcionarios { get; set; }
        public string nome { get { return e_nome; } set { e_nome = value; } }
        public Equipas(string name)
        {
            this.nome = name;
            funcionarios = new List<Funcionarios>(); 
        }
    }
}
