using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace escola
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }

        public Aluno(string nome, string curso)
        {
            Nome = nome;
            Curso = curso;
            Avaliacoes = new List<Avaliacao>();
        }

        public void AdicionarNota(Avaliacao avaliacao, double valor)
        {
            avaliacao.AdicionarNota(valor);
            Avaliacoes.Add(avaliacao);
        }

        public double CalcularMedia()
        {
            double somaNotas = 0;
            int somaPesos = 0;
            foreach (var avaliacao in Avaliacoes)
            {
                somaNotas += avaliacao.Valor * avaliacao.Peso;
                somaPesos += avaliacao.Peso;
            }
            return somaPesos > 0 ? somaNotas / somaPesos : 0;
        }
    }
}