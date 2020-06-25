using System.Web.Http;

namespace CQRS.Sample.Controllers
{
    public class EmployeeQueryController : ApiController
    {
        // Query controllers are directly reading data from database.
        // Create Readmodel classes with the properties which are required to read,
        // and fetch them from database.
    }
}
