using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Disciplina
    {
        public string Nome { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }

        public Disciplina(string nome)
        {
            Nome = nome;
            Avaliacoes = new List<Avaliacao>();
        }

        public void AdicionarAvaliacao(string descricao, int peso)
        {
            Avaliacoes.Add(new Avaliacao(descricao, peso));
        }
    }
}