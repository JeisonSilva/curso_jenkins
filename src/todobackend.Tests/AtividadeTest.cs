using FluentAssertions;
using System.Linq;
using todobackend.CriacaoListaTarefas.Entities;
using Xunit;

namespace todobackend.Tests
{
    public class AtividadeTest
    {
        private readonly Atividade atividade;

        public AtividadeTest()
        {
            this.atividade = new Atividade();
        }

        [Fact]
        [Trait("Atividade","Deve criar uma tarefa com descricao")]
        public void Deve_Criar_Uma_Tarefa_Com_Descricao()
        {
            var descricao = "Criar uma tarefa";
            this.atividade.CriarNovaTarefa(descricao);

            this.atividade.Tarefas
                .Where(x => x.Descricao == descricao)
                .FirstOrDefault()
                .Should()
                .NotBeNull();
        }
    }
}
