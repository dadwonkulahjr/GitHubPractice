using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubPractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Employee(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id = {Id}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Email = {Email}");
        }
    }
}
