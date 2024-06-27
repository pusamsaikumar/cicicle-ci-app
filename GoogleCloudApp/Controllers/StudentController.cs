using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoogleCloudApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController()
        {
            
        }
        [HttpGet]
        [Route("GetStudentDetails")]
        public IActionResult GetstudentDetails()
        {
            return Ok(new
            {
                Name="P. Sai Kumar",
                AGE="28",
                DateofBirth ="09-11-1994",
                Marks="523",
                Grades="A1"


            });
        }
    }
}
