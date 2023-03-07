using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T16CodBackEnd.Interfaces;

namespace T16CodBackEnd.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public int cpf { get; set; }
        public DateTime dataNasc { get; set; }
        


        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}