using ControleCinema.ConsoleApp.Compartilhado;
using System;

namespace ControleCinema.ConsoleApp.ModuloSala
{
    public class Sala : EntidadeBase
    {
        public string Descricao { get; set; }

        public Sala(string descricao)
        {
            Descricao = descricao;
        }
    }
}
