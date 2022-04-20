namespace SOLID;

public interface ICrud<T>
{
    public T Get(int id);
    public List<T> GetList();
    public void Add(T entity);
    public void Update(T entity);
    public void Delete(T entity);
    
}

public interface IBasicActions<T>
{
    public T Get(int id);
    public List<T> GetList();
    public void Add(T entity);
}
public interface IEditableActions<T>
{
    public void Update(T entity);
    public void Delete(T entity);
}

public class UserService : IBasicActions<User>,IEditableActions<User>
{
    public User Get(int id)
    {
        return new User();
    }

    public List<User> GetList()
    {
        return new List<User>();
    }

    public void Add(User entity)
    {
        Console.WriteLine("Add");
    }

    public void Update(User entity)
    {
        Console.WriteLine("Update");
    }

    public void Delete(User entity)
    {
        Console.WriteLine("Delete");
    }
}

public class VentaService : IEditableActions<Venta>
{
    public void Update(Venta entity)
    {
        Console.WriteLine("Update");
    }

    public void Delete(Venta entity)
    {
        Console.WriteLine("Delete");
    }
}


public class User
{
    public int Id { get; set; }
    public int Name { get; set; }
    public int Email { get; set; }
}

public class Venta
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
}