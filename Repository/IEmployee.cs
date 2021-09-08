using dependencyInjection.Models;
namespace dependencyInjection.Repository
{
    public interface IEmployee
    {
         int CreateEmployee(Employee obj);
    }
}