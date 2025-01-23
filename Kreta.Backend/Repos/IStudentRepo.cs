using Kreta.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;

namespace Kreta.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        Task<Student> GetByNameAsync(string firstName, string lastName);
        Task<List<Student>> GetStudentByClassAsync(int schoolYear, SchoolClassType schoolClassType);
        Task<int> GetNumberOfStudentAsync();
    }
}
