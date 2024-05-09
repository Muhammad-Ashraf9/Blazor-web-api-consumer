using Microsoft.AspNetCore.Components;

namespace Day3.Pages.Student
{
    public partial  class StudentListComponent
    {
        [Inject]
        public IService<StudentResponseModel> StudentService { get; set; }

        public List<StudentResponseModel> StudentList { get; set; }

        protected override async Task OnInitializedAsync()
        {
            StudentList = await StudentService.GetAll();
             base.OnInitializedAsync();
        }
    }
}
