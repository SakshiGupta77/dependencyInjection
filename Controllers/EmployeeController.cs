using Microsoft.AspNetCore.Mvc;
using dependencyInjection.Repository;
using dependencyInjection.Models;
namespace dependencyInjection.Controllers
{
    [ApiController] //action filter
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        IEmployee list1;
        public EmployeeController(IEmployee ilist)
        {
           list1=ilist; //memory allocation without new
        }
        [HttpPost]
        public Employee CreateEmployeeData(Employee temp)
        {
            int t = list1.CreateEmployee(temp);
            if (t==0)
            {
                
            }
            return temp;
        }
    }
}