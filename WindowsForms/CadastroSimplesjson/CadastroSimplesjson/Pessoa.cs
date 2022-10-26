using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimplesjson
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNesc { get; set; }
        public string Cpf{ get; set; }
        public string Cep { get; set; }
        public string endereco { get; set; }
        public string Bairro { get; set; }
        public string cidade { get; set; }
        public string Uf { get; set; }

        public Pessoa()
        {

        }
    }
}
