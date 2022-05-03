using eAgenda.Dominio;
using System.Collections.Generic;

namespace eAgenda.Infra.Interfaces
{
    public interface ITaskRespository
    {
        void AddItens(Task task, List<Item> items);
        void UpdateItens(Task task, List<Item> completedItens, List<Item> pendingItems);
        void AddTask(Task task);
        void DeleteTask(Task task);
        List<Task> GetAll();
        List<Task> GetCompletedTasks();
        List<Task> GetPendingTasks();
    }
}