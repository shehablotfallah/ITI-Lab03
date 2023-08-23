using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01;
internal class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }
    public string Address { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public Employee(string firstName, string lastName, double salary, string address, int age, Gender gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        Address = address;
        Age = age;
        Gender = gender;
    }

    public void Print()
    {
        Console.WriteLine($"\n Name: {FirstName} {LastName}, Age: {Age}, Address: {Address}, Salary: {Salary}, Gender: {Gender}");
    }
}

