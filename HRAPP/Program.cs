using HRLib;

namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee employee;
            ConfirmEmployee employee1;

            Trainee intern1=new Trainee();
            Trainee intern2= new Trainee("Intername","Kolhapuri",50,1000);
            try
            {
                employee = new ConfirmEmployee();
                //employee.Basic = 100;
                employee1 = new ConfirmEmployee("sample 1", "Pune", 3000, "SDE1");
                Console.WriteLine(employee);
                Console.WriteLine(employee1);

            }
            catch (MinimumPayException ex) {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(intern1);
            Console.WriteLine(intern2);

        }
    }
}
