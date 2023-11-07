using System.Drawing;

namespace Labb_4___Collection_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*DEL 1*/
            Employee em1 = new Employee(1, "Ludwig", "Male", 27000);
            Employee em2 = new Employee(2, "Sara", "Female", 29000);
            Employee em3 = new Employee(3, "Kevin", "Male", 19000);
            Employee em4 = new Employee(4, "Anna", "Female", 23000);
            Employee em5 = new Employee(5, "Linus", "Male", 31000);
            Stack<Employee> EmpStack = new Stack<Employee>();

            //Lägger till objekt
            EmpStack.Push(em1);
            EmpStack.Push(em2);
            EmpStack.Push(em3);
            EmpStack.Push(em4);
            EmpStack.Push(em5);

            //skriver ut objekt
            foreach (Employee item in EmpStack)
            {
                Console.WriteLine($"\nID: {item._id}, Name: {item._name}, Gender: {item._gender}, Salary: {item._salary}" +
                    $"\nIt is {EmpStack.Count} employees left in the stack");

            }

            //skriver ut och tar bort objekt
            while (EmpStack.Count > 0)
            {
                Employee emppop = EmpStack.Pop();
                {
                    Console.WriteLine($"\nRetrieved using pop method" +
                        $"\nID: {emppop._id}, Name: {emppop._name}, Gender: {emppop._gender}, Salary: {emppop._salary}" +
                        $"\nIt is {EmpStack.Count} employees left in the stack");
                }
            }

            //lägger till objekt igen
            EmpStack.Push(em1);
            EmpStack.Push(em2);
            EmpStack.Push(em3);
            EmpStack.Push(em4);
            EmpStack.Push(em5);

            //Använder peek-metoden för att se vilket objekt som är först i stacken
            Employee peekyemp = EmpStack.Peek();
            {
                Console.WriteLine($"\nRetrieved using peek method" +
                    $"\nID: {peekyemp._id}, Name: {peekyemp._name}, Gender: {peekyemp._gender}, Salary: {peekyemp._salary}" +
                    $"\nIt is {EmpStack.Count} employees left in the stack");
            }
            peekyemp = EmpStack.Peek();
            {
                Console.WriteLine($"\nRetrieved using peek method" +
                    $"\nID: {peekyemp._id}, Name: {peekyemp._name}, Gender: {peekyemp._gender}, Salary: {peekyemp._salary}" +
                    $"\nIt is {EmpStack.Count} employees left in the stack");
            }
            //^Peek metoden kommer alltid visa den som är först i stacken

            //Skriver ut om objekt 3 (em3) finns i stacken
            if (EmpStack.Contains(em3))
            {
                Console.WriteLine($"\nEmp3 is in the stack");
            }
            else
            {
                Console.WriteLine($"\nEmp3 is not in the stack");
            }



            /*DEL 2*/

            List<Employee> empList = new List<Employee>();

            //Lägger till objekt i listan
            empList.Add(em1);
            empList.Add(em2);
            empList.Add(em3);
            empList.Add(em4);
            empList.Add(em5);

            //Kolla ifall listan innehåller employee 4
            if (empList.Contains(em3))
            {
                Console.WriteLine($"Employee 4 finns i listan, det är {em4._name}");
            }
            else
            {
                Console.WriteLine("Finns inte i listan");
            }

            //Hittar första "manliga" objektet i listan
            Employee findMale = empList.Find(e => e._gender == "Male");
            if (findMale != null)
            {
                Console.WriteLine($"\nMale employee found....ID: {findMale._id}, Name: {findMale._name}, Gender: {findMale._gender}, Salary: {findMale._salary}");
            }
            else
            {
                Console.WriteLine("Cannot find any male");
            }

            List<Employee> findAllMales = empList.FindAll(e => e._gender == "Male");
            if (findAllMales.Count > 0)
            {
                Console.WriteLine("All male employees found!");
                foreach (var maleemployee in findAllMales)
                {
                    Console.WriteLine($"\nMale employee found....ID: {maleemployee._id}, Name: {maleemployee._name}, Gender: {maleemployee._gender}, Salary: {maleemployee._salary}");
                }
            }
            else
            {
                Console.WriteLine("No male employees found...");
            }
        }
    }   
}