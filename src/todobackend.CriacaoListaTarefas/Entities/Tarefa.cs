namespace todobackend.CriacaoListaTarefas.Entities
{
    public class Tarefa
    {
        public Tarefa(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; }
    }
}
