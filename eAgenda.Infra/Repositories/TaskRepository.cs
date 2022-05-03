using eAgenda.Dominio;
using eAgenda.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Repositories
{
    public class TaskRepository : ITaskRespository
    {
        private readonly ISerializator<Task> _serializator;
        private readonly List<Task> _tasks;

        public TaskRepository(ISerializator<Task> serializator)
        {
            _serializator = serializator;
            _tasks = serializator.Load();
        }

        public void AddItens(Task task, List<Item> items)
        {
            foreach (Item item in items)
            {
                task.AddItem(item);
            }

            _serializator.Save(_tasks);
        }

        public void UpdateItens(Task task, List<Item> completedItens, List<Item> pendingItems)
        {
            foreach (Item item in completedItens)
            {
                task.SetItemCompleted(item);
            }

            foreach (Item item in pendingItems)
            {
                task.SetItemPending(item);
            }
            _serializator.Save(_tasks);
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
            _serializator.Save(_tasks);
        }

        public void DeleteTask(Task task)
        {
            _tasks.Remove(task);
            _serializator.Save(_tasks);
        }

        public List<Task> GetAll()
        {
            return _tasks;
        }

        public List<Task> GetCompletedTasks()
        {
            return _tasks.Where(x => x.GetCompletedProcentage() == 100.0).OrderBy(x => x.TaskPriority).ToList();
        }

        public List<Task> GetPendingTasks()
        {
            return _tasks.Where(x => x.GetCompletedProcentage() < 100.0).OrderBy(x => x.TaskPriority).ToList();
        }
    }
}