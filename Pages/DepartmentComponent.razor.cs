using BlazorApp1.Models;

namespace BlazorApp1.Pages
{
    public partial class  DepartmentComponent
    {
        public int deptId { get; set; }
        public Department dept { get; set; }
        public List<Department> ListDepts { get; set; }
        public DepartmentComponent()
        {
            ListDepts = new List<Department>();
            ListDepts.Add(new Department() { ManagerName="ali",Name="sd"});
            ListDepts.Add(new Department() { ManagerName="ali",Name="gb"});
            ListDepts.Add(new Department() { ManagerName = "ali", Name = "br" });
            ListDepts.Add(new Department() { ManagerName = "ali", Name = "vc" });


        }
        public void getdept()
        {
             dept=ListDepts.FirstOrDefault(d => d.Id == deptId);
        }
    }
}
