using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace es.Slide_370
{
    public class Materia
    {
        public string Nome
        {
            get => default;
            set
            {
            }
        }

        public string SiglaIdentificativa
        {
            get => default;
            set
            {
            }
        }

        public Materia(string nome, string sigla)
        {
            Nome = nome;
            SiglaIdentificativa = sigla;
        }
    }
}