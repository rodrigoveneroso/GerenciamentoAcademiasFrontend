using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_GUI.Models
{
    internal class MAlunos
    {
        public int Id_aluno { get; set; }
        public string CPF_aluno { get; set; }
        public string Data_nascimento_aluno { get; set; }
        public string Status { get; set; }

        public string Telefone_aluno { get; set; }
        public string Email_aluno { get; set; }
        public string Nome_aluno { get; set; }
        public int? Id_endereco { get; set; }
        public int? Id_aula { get; set; }
        public int? Id_contrato { get; set; }
    }
}
