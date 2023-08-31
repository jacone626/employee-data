using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
 class Program
{
  static void PrintEmployees(List<Employee> employees)
  {
    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
  }
  async static Task Main(string[] args)
  {
    // List<Employee> employees = PeopleFetcher.GetEmployees();
    List<Employee> employees = await PeopleFetcher.GetFromApi();
    Util.PrintEmployees(employees);
    Util.MakeCSV(employees);
    await Util.MakeBadges(employees);
  }
}
}