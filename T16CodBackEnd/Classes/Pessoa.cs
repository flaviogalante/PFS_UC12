using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T16CodBackEnd.Interfaces;


namespace T16CodBackEnd.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome { get; set; }
        public string? endereco { get; set; }
        public float rendimento { get; set; }


        public float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}