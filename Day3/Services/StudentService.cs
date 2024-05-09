
using System.Net.Http.Json;

namespace Day3.Services
{
    public class StudentService : IService<StudentResponseModel>
    {
        private readonly HttpClient client;
        public StudentService(HttpClient httpClient) 
        {
            client = httpClient;
        }
        public Task<List<StudentResponseModel>> GetAll()
        {
            var resp = client.GetFromJsonAsync<List<StudentResponseModel>>("api/Students");
            return resp;
        }

        public async Task<StudentResponseModel> GetById(int id)
        {
            var resp =await client.GetFromJsonAsync<StudentResponseModel>($"/api/students/{id}");
            return resp;
        }

        public async Task<bool> Update(int id, StudentResponseModel entity)
        {
            HttpResponseMessage response =await client.PutAsJsonAsync($"/api/students/{id}",entity);

            if (response.IsSuccessStatusCode) return true;
            else return false;
        }

        public Task Insert(StudentResponseModel entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
