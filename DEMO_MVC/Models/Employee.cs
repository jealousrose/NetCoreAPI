namespace DEMO_MVC.Models
{
    // Employee kế thừa từ Person
    public class Employee : Person
    {
        public string EmployeeId { get; set; } 
        public int Age { get; set; }           
    }
}
