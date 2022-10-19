namespace firstMVCAPP.Models
{
    public class EmployeeDetailsModel
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public string empDesignation { get; set; }
        public int empSalary { get; set; }
        public bool empIsPermenant { get; set; }

        static List<EmployeeDetailsModel> eList = new List<EmployeeDetailsModel>()
        {
            new EmployeeDetailsModel(){ empNo=101, empName="Nikhil", empDesignation="Consultant", empIsPermenant=true, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=102, empName="Karan", empDesignation="HR", empIsPermenant=true, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=103, empName="Mohan", empDesignation="Consultant", empIsPermenant=false, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=104, empName="Rohan", empDesignation="Sales", empIsPermenant=true, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=105, empName="Nidhi", empDesignation="Consultant", empIsPermenant=true, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=106, empName="Riddhi", empDesignation="Sales", empIsPermenant=false, empSalary=5000},
            new EmployeeDetailsModel(){ empNo=107, empName="Sonam", empDesignation="Consultant", empIsPermenant=true, empSalary=5000},
        };



        public List<EmployeeDetailsModel> GetAllEmployee()
        {
            return eList;
        }
    }
}




