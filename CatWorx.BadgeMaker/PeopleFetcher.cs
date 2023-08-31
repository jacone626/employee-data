using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CatWorx.BadgeMaker 
{
  class PeopleFetcher 
  {
    // code from GetEmployees() in Program.cs
    public static List<Employee> GetEmployees()
  {
    List<Employee> employees = new List<Employee>();
    while (true)
    {
      Console.WriteLine("Please enter a name: (leave empty to exit): ");
      string firstName = Console.ReadLine() ?? "";
      if (firstName == "")
      {
        break;
      }
      // add a Console.ReadLine() for each value
      Console.Write("Enter last name: ");
      string lastName = Console.ReadLine() ?? "";
      Console.Write("Enter ID: ");
      int id = Int32.Parse(Console.ReadLine() ?? "");
      Console.Write("Enter Photo URL:");
      string photoUrl = Console.ReadLine() ?? "";
      Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
      employees.Add(currentEmployee);
    }
    return employees;
  }
  async public static Task<List<Employee>> GetFromApi() 
    {
    List<Employee> employees = new List<Employee>();
    using (HttpClient client = new HttpClient())
        {

        }
    return employees;
    }
  }
}