using Kreta.Backend.Controllers.Base;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    public partial class StudentController : BaseController<Student, StudentDto>
    {
        [HttpGet("NumberOfStudent")]
        public async Task<IActionResult> GetNumberOfStudent()
        {
            return Ok(await _studentRepo.GetNumberOfStudentAsync());
        }
    }
}
