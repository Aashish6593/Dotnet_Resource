using Partial_class;

class Program
{
    static void Main()
    {   
        //Object of employee
        Employee ep = new Employee();
        ep.EmployeName();
        ep.EmployeeDepartment();
        ep.EmployeeSalary();

        //Object of person
        Person p = new Person();
         p.FirstName = "Aashish";
         p.LastName = "Khatiwada";
         p.Age = 22;
         p.Email = "aashishkhatiwada0202@gmail.com";
         p.Number = "9812386593";
         p.PersonDetails();
         p.ContactDetails();



    }
}
