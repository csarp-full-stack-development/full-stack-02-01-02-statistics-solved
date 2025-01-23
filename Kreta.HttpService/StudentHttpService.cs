using Kreta.HttpService.Base;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using System.Net.Http.Json;

namespace Kreta.HttpService
{
    public class StudentHttpService : BaseHttpService<Student, StudentDto>, IStudentHttpService
    {
        public StudentHttpService(IHttpClientFactory? httpClientFactory, StudentAssembler assambler) : base(httpClientFactory, assambler)
        {
        }

        public StudentHttpService() : base()
        {            
        }

        public async Task<int> GetNumberOfStudentAsync()
        {
            try
            {
                int numberOfStudent = await _httpClient.GetFromJsonAsync<int>("api/Student/NumberOfStudent");
                return numberOfStudent;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return -1;
        }
    }
}
