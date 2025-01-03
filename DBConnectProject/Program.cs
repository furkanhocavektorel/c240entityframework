
using DBConnectProject.context;


namespace DBConnectProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

         
            DbBaglan baglan = new DbBaglan();
            baglan.Employees.ToList().ForEach(x => Console.WriteLine(x.FirstName));



        }

    }
}






