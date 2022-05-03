using System.Collections.Generic;

namespace eAgenda.Infra.Interfaces
{
    public interface ISerializator<T> where T : class
    {
        List<T> Load();
        void Save(List<T> t);
    }
}