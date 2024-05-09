using Microsoft.AspNetCore.Components;

namespace Day3.Pages.Student
{
    public partial class EditStudentComponent
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IService<StudentResponseModel> StudentService { get; set; }

        [Inject] 
        public IService<DepartmentResponseDTO> DepartmentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public List<DepartmentResponseDTO> DepartmentList { get; set; }

        public EditStudentBodyDTO Student { get; set; }

        public bool IsUpdatedSuccessfully { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            StudentResponseModel resp =  await StudentService.GetById(Id);
            Student = new EditStudentBodyDTO()
            {
                StFname = resp.StFname,
                StAddress = resp.StAddress,
                StAge = resp.StAge,
                StLname = resp.StLname,
                DeptId = resp.DeptId
            };
            DepartmentList = await DepartmentService.GetAll();
            base.OnInitializedAsync();
        }

        public async Task Save()
        {
            StudentResponseModel std = new StudentResponseModel()
            {
                StFname = Student.StFname,
                StAddress = Student.StAddress,
                StAge = Student.StAge,
                StLname = Student.StLname,
                DeptId = Student.DeptId
            }; 
           IsUpdatedSuccessfully=  await StudentService.Update(Id, std);
           NavigationManager.NavigateTo("/students");
        }
    }
}
