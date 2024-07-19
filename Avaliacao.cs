using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    internal class Avaliacao
    {
        public string Descricao { get; set; }
        public int Peso { get; set; }
        public double Valor { get; set; }

        public Avaliacao(string descricao, int peso)
        {
            Descricao = descricao;
            Peso = peso;
            Valor = 0.0;
        }

        public void AdicionarNota(double valor)
        {
            if (valor < 0 || valor > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(valor), "Nota deve ser um valor entre 0 e 10.");
            }
            Valor = valor;
        }
    }

}
