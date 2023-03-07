using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T16CodBackEnd.Interfaces;

namespace T16CodBackEnd.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public int cnpj { get; set; }
        public string? razaoSocial { get; set; }


        
        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        }

    }
}