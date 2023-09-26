using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAutores
{
    internal class Autores
    {
        public string Nome { get ; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
    }
}
