namespace FrangoZe.Domain.Interfaces;
public interface IDAO<T>
{
    public void Insert(T t);
    public void Update(T t);
    public T GetById(int id);
    public void Delete(int id);
}
