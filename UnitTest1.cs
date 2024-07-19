using Xunit;
using escola;

namespace MeuProjeto.Testes
{
    public class AlunoTestes
    {
        [Fact]
        public void CalcularMedia_Teste()
        {
            
            var aluno = new Aluno("João Silva", "Engenharia");
            aluno.AdicionarNota(new Avaliacao("Prova 1", 1), 10);
            aluno.AdicionarNota(new Avaliacao("Prova 2", 2), 10);

           
            var media = aluno.CalcularMedia();

           
            Assert.Equal(10, media, 2); 
        }
    }
}
