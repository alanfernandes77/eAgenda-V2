using eAgenda.Dominio.Enums;

namespace eAgenda.Dominio
{
    public class Item
    {
        public string Description { get; set; }
        public ItemStatus Status { get; set; }

        public Item(string description)
        {
            Description = description;
            Status = ItemStatus.Pendente;
        }

        public void SetCompleted()
        {
            Status = ItemStatus.Completado;
        }

        public void SetPending()
        {
            Status = ItemStatus.Pendente;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}