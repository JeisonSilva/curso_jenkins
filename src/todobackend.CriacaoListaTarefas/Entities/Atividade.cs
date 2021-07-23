using System;
using System.Collections.Generic;

namespace todobackend.CriacaoListaTarefas.Entities
{
    public class Atividade
    {
        public Atividade()
        {
            Tarefas = new List<Tarefa>();
        }

        public List<Tarefa> Tarefas { get;}

        public void CriarNovaTarefa(string descricao)
            => Tarefas.Add(new Tarefa(descricao));
    }
}
