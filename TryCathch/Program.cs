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
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("yanlis formatta girdi");

            }
            catch (DivideByZeroException e)
            {
            }
            catch(Exception e)
            {

            }
            finally {
                Console.WriteLine("kullanici islem yapmaya calisiyor...");

            }






            Console.WriteLine("devma ediyor mu kodumuz");







        }
    }
}
