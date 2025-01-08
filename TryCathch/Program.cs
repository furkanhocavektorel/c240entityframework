namespace TryCathch
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
              int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                double sonuc = b / a;
                Console.WriteLine(sonuc);
  
            }
            catch (Exception ex)
            {
                Console.WriteLine("sql bağlantısında sıkıntı var");
                Console.WriteLine("norhwind contex cllassı içinde " +
                    "option builder hatalı");
            }

           


            Console.WriteLine("devma ediyor mu kodumuz");







        }
    }
}
