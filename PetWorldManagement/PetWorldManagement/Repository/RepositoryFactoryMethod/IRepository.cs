using System.Data;
namespace PetWorldManagement
{
    public interface IRepository<T>
    {
        DataTable GetAll();
        DataTable Search(string keyword);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
