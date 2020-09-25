using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDrugScreens
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            int selection = 1;
            int numDayTestLimit = -180;
            DateTime dateTestLimit = DateTime.Today.AddDays(numDayTestLimit);
            var rand = new Random();
            
            StreamReader reader = new StreamReader(@"C:\Users\rbask\source\repos\EmployeeDrugScreens\EmployeeDrugScreens\Employee Drug Test Dates.csv");
            Dictionary<int, DateTime> employeeInfoData = new Dictionary<int, DateTime>();
            Dictionary<int, DateTime> employeesToTest = new Dictionary<int, DateTime>();
            Dictionary<int, DateTime> employeesSelectedForTesting = new Dictionary<int, DateTime>();

            while (line != null)
            {
                line = reader.ReadLine();

                if (line != null)
                {
                    string[] employeeInformation = line.Split(',');
                    employeeInfoData.Add(Convert.ToInt32(employeeInformation[0]),
                        DateTime.Parse(employeeInformation[3]));

                    // Test employee ID# and first/last name
                    //Console.WriteLine($"{employeeInformation[0]}: {employeeInformation[1]}, {employeeInformation[2]}");
                    // Test drug test date format
                    //Console.WriteLine($"{employeeInformation[3]}");
                }
            }
            Console.WriteLine("Employees Drug Test Quary");
            Console.WriteLine("Return Employees with test dates less month: ");

            //string userInput = Console.ReadLine();
            //bool convertUserInput = int.TryParse(userInput, out int userInputMonth);

            foreach (KeyValuePair<int, DateTime> entry in employeeInfoData.OrderBy(value => value.Value))
            {
                if (entry.Value <= dateTestLimit)
                    employeesToTest.Add(entry.Key, entry.Value);
                //Console.WriteLine("ID: {0}: Last Drug Test:{1: MM/dd/yy}", entry.Key, entry.Value);
            }

            for (int i = 0; i < 50; i++)
            {
                int selectionNext = rand.Next(employeesToTest.Count);
                if (!employeesSelectedForTesting.ContainsKey(employeesToTest.ElementAt(selectionNext).Key))
                {
                    employeesSelectedForTesting.Add(employeesToTest.ElementAt(selectionNext).Key,
                        employeesToTest.ElementAt(selectionNext).Value);
                }
                else
                    i--;
                
            }
            foreach (KeyValuePair<int, DateTime> entry in employeesSelectedForTesting)
            {
                Console.WriteLine($"Selection #:{selection}   " + "ID: {0}: Last Drug Test:{1: MM/dd/yy}", entry.Key, entry.Value);
                selection++;
            }
            Console.ReadLine();
        }
    }
}
