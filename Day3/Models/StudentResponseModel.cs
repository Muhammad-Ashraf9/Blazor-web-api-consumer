using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class StudentResponseModel
    {
        public int StId { get; set; }

        [MinLength(3,ErrorMessage = "First Name has to be at least 3 Chars")]
        [MaxLength(50,ErrorMessage = "First name has to be at most 50 chars")]
        public string StFname { get; set; }
        public string StLname { get; set; }
        public string StAddress { get; set; }
        public int StAge { get; set; }
        public string DeptName { get; set; }
        public string StSuper { get; set; }
        public int DeptId { get; set; }

    }
}
