using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T16CodBackEnd.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}