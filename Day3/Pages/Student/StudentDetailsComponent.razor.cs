using Microsoft.AspNetCore.Components;

namespace Day3.Pages.Student
{
    public partial class StudentDetailsComponent
    {
        [Parameter]
        public int Id { get; set; }

        [Inject]
        public IService<StudentResponseModel> StudentService { get; set; }

        public StudentResponseModel Student { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student= await StudentService.GetById(Id);
            base.OnInitializedAsync();
        }
    }
}
