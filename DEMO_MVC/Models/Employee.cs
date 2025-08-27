namespace DEMO_MVC.Models
{
    // Employee kế thừa từ Person
    public class Employee : Person
    {
        public string EmployeeId { get; set; } // Mã nhân viên
        public int Age { get; set; }           // Tuổi
    }
}
