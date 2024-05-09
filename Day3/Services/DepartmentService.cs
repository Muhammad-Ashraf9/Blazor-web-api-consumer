using System.Net.Http.Json;

namespace Day3.Services
{
    public class DepartmentService: IService<DepartmentResponseDTO>
    {
        HttpClient client;

        public DepartmentService(HttpClient httpClient)
        {
            client = httpClient;
        }


        public Task<List<DepartmentResponseDTO>> GetAll()
        {
            return client.GetFromJsonAsync<List<DepartmentResponseDTO>>("/api/departments");
        }

        public Task<DepartmentResponseDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, DepartmentResponseDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task Insert(DepartmentResponseDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
