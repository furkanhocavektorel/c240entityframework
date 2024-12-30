namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayi1 giriniz");
            int a= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("sayi2 giriniz");
            int b = Convert.ToInt32(Console.ReadLine());


            Islem<int,double> islem = new Islem<int,double>();

            islem.bolme(a,b);


        }
    }
}
