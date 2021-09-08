using dependencyInjection.Models;
namespace dependencyInjection.Repository
{
    public class EmployeeList :IEmployee
    {
        public int CreateEmployee(Employee obj)
        {
            //at this point we need to call EF core to save record in database
            return 1;
        }
    }
}