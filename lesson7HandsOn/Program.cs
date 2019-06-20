using System;

namespace lesson7HandsOn
{
    class Employee
    {
        string name;
        int salary;
        string hireDate;

        public Employee(string name, int salary, string hireDate)
        {
            this.name = name;
            this.salary = salary;
            this.hireDate = hireDate;
        }
        public virtual void getName()
        {
            Console.WriteLine("Employee Name: " + this.name);
        }
        public virtual void getSalary()
        {
            Console.WriteLine("Salary: " + this.salary);
        }
        public virtual void hiredDate()
        {
            Console.WriteLine("Hire Date: " + this.hireDate);
        }
    }

    class Engineer: Employee
    {
        string schoolAttended;
          public Engineer (string name, int salary, string hireDate, string schoolAttended)
          :base (name, salary,hireDate)
          {
              this.schoolAttended = schoolAttended;

          }
           }

           class SoftwareEngineer:Engineer
           {
        public SoftwareEngineer (string name, int salary, string hireDate, string schoolAttended)
               :base (name,salary,hireDate, schoolAttended)
               {}
               public override void getSalary()
               {
                Console.WriteLine("Salary: Sorry this employees salary is private.");
               }
           }
            
            class Program   
           {

            static void Main()
        {

            Engineer engineer1 = new Engineer("Joshua Lambert", 114000, "11/22/12", "NYU");
            engineer1.getName();
            engineer1.getSalary();
            engineer1.hiredDate();
            Console.WriteLine("----------------------------------------------------------------");

            SoftwareEngineer  softwareEngineer1 = new SoftwareEngineer("Marla Singh" , 999000 , "03/27/18", "Harvard");
            softwareEngineer1.getName();
            softwareEngineer1.getSalary();
            softwareEngineer1.hiredDate();
        }
        }
}
        
    
    



