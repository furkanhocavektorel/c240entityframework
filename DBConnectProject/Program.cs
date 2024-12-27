
using DBConnectProject.context;
using DBConnectProject.controller;
using DBConnectProject.entity;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerController controller= new CustomerController();

           // controller.save("ba","Vektorel", "ali mehmet");

            bool b=controller.update("ba", "ercan balikcilik");

            if (b)
            {
                Console.WriteLine("güncelleme basarili");
            }
            else 
            {
                Console.WriteLine("güncelleme basarisiz");

            }



        }

    }
}






