using ControleCinema.ConsoleApp.Compartilhado;
using System;

namespace ControleCinema.ConsoleApp.ModuloFilme

    {
        public class Filme : EntidadeBase
        {
            public string Descricao { get; set; }

            public Filme(string descricao)
            {
                Descricao = descricao;
            }
        }
    
}

