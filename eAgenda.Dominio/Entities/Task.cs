using eAgenda.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Dominio
{
    public class Task
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public TaskPriority TaskPriority { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ConclusionDate { get; set; }
        public List<Item> Items { get; }

        public Task(string title, TaskPriority taskPriority)
        {
            Number = new Random().Next(1000, 10000);
            Title = title;
            TaskPriority = taskPriority;
            CreationDate = DateTime.Now;
            ConclusionDate = null;
            Items = new();
        }

        public void AddItem(Item item)
        {
            if (Items.Exists(x => x.Equals(item)) == false)
                Items.Add(item);
        }

        public void SetItemCompleted(Item item)
        {
            Item taskItem = Items.Find(x => x.Equals(item));

            taskItem.SetCompleted();

            if (GetCompletedProcentage() == 100.0)
                ConclusionDate = DateTime.Now;
        }

        public void SetItemPending(Item item)
        {
            Item taskItem = Items.Find(x => x.Equals(item));

            taskItem?.SetPending();
        }

        public double GetCompletedProcentage()
        {
            if (Items.Count == 0)
                return 0;

            int completedItens = Items.Count(x => x.Status == ItemStatus.Completado);

            return Math.Round((double) completedItens / Items.Count * 100, 2);
        }

        public string GetStatus()
        {
            if (GetCompletedProcentage() == 100.0)
                return "Concluída";

            return "Pendente";
        }
    }
}
