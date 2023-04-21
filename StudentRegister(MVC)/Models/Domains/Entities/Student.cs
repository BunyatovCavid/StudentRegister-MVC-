using System;

namespace StudentRegister_MVC_.Models.Domains.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public DateTime Date { get; set; }
    }
}
