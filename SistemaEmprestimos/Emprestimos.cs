using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimos
{
    internal class Emprestimos
    {
        public string EmprestimoID { get; set; }
        public string ClienteID { get; set; }
        public string LivroID { get; set; }
        public DateTime DataEmprestimos { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
