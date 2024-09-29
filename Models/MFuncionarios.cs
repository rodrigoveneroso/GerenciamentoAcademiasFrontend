using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia_GUI.Models
{
    internal class MFuncionarios
    {
        public int Id_funcionario { get; set; }

        public string CPF_funcionario { get; set; }
        public string Data_nascimento_funcionario { get; set; }
        public string Status { get; set; }
        public string Telefone_funcionario { get; set; }
        public decimal Salario_funcionario { get; set; }
        public string Email_funcionario { get; set; }
        public string Nome_funcionario { get; set; } 
        public string Cargo_Funcionario { get; set; }
        public int? Id_endereco { get; set; }
        public int? Id_despesas { get; set; }
        public int? Id_aula { get; set; }
    }
}
