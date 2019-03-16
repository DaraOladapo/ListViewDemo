using System;
namespace ListViewDemo.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Level { get; set; } = 100;//default level to 100
    }
}
