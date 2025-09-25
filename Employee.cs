using System;
using System.Collections.Generic;

public class Employee
{
    public string? Name { get; set; }
    public string? Job { get; set; }
    public double Salary { get; set; }

    public virtual double CalculateBonus()
    {
        // All employees get 5% bonus
        return Salary * 0.05;
    }
}

public class Manager : Employee { }
public class Engineer : Employee { }
public class Intern : Employee { }
public class Cleaner : Employee { }

public class EmployeeBonusCalculator
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Manager { Name = "Sudeep", Job = "Manager", Salary = 100000 },
            new Engineer { Name = "Rakesh", Job = "Engineer", Salary = 80000 },
            new Intern { Name = "Pavan", Job = "Intern", Salary = 50000 },
            new Cleaner { Name = "Manju", Job = "Cleaner", Salary = 30000 }
        };

        foreach (var employee in employees)
        {
            Console.WriteLine($"{employee.Job} {employee.Name}'s bonus: {employee.CalculateBonus()}");
        }
    }
