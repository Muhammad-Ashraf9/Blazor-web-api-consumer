namespace Day3.Models
{
    public class DepartmentResponseDTO
    {
       
            public int DeptId { get; set; }

            public string DeptName { get; set; }

            public string DeptDesc { get; set; }

            public string DeptLocation { get; set; }

            public int? DeptManager { get; set; }

            public int NumberOfStudents { get; set; }
    }
}
