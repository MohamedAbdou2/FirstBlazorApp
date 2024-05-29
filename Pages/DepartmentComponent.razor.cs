using FirstBlazorApp.Models;

namespace FirstBlazorApp.Pages
{
    public partial class DepartmentComponent
    {
        public int SelectDeptId { get; set; } = 3;
        public List<Department> DepartmentList { get; set; }
        public Department Department { get; set; }

        public DepartmentComponent()
        {
            DepartmentList = new List<Department>();
            DepartmentList.Add(new Department()
            {
                Id = 1,
                Name = "SD",
                ManagerImage = "manager.jpg"

            });

            DepartmentList.Add(new Department()
            {
                Id = 2,
                Name = "OS",
                ManagerImage = "woman.jpeg"

            });

            DepartmentList.Add(new Department()
            {
                Id = 3,
                Name = "PD",
                ManagerImage = "manager.jpg"

            });

            Department = new Department()
            {
                Id = 1,
                Name = "SD",
                ManagerImage = "manager.jpg"

            };


        }

        private void LoadDept()
        {
            Department = DepartmentList.FirstOrDefault(d => d.Id == SelectDeptId);
        }
    }
}
