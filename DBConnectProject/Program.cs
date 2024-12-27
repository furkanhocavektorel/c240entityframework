using DBConnectProject;
using Microsoft.EntityFrameworkCore;
using System.Linq;



DbBaglan dbBaglan = new DbBaglan();

List<Customers> musteriList = dbBaglan.Customers.ToList();

// sorgular için en çok kullanılan iki yöntem vardır
// 1_LINQ
// 2_Native = select * from dbo.customers
// LAMBDA

List<Customers> tamami = dbBaglan.Customers.ToList();

// LAMBDA BİLMEDEN ONCE
//List<Customers> filtreli= new List<Customers>();

//foreach (Customers item in tamami)
//{
//    if (item.City.Equals("London"))
//    {
//        filtreli.Add(item);
//    }
//}

// IQ IE

// IE
// ram +++++
// db  +

List<Customers> filtre2 =
dbBaglan.Customers
.ToList()
.Where(x => x.City.Equals("London"))
.ToList();


List<Customers> filtre3 =
 dbBaglan.Customers
 .Where(x => x.City.Equals("London"))
 .ToList();


List<Customers> customer =
    dbBaglan.Customers
    .Where(x => x.City.Equals("Berlin"))
   .OrderBy(x => x.City)
   .ToList();

Customers c =
    dbBaglan.Customers.FirstOrDefault(x => x.CustomerId.Equals("DUMOR"));

if (c != null)
{
    dbBaglan.Customers.Remove(c);
    dbBaglan.SaveChanges();
}



List<Customers> cList = dbBaglan.Customers
     .FromSqlRaw("select * from customers")
     .ToList();







Console.WriteLine("lütfen bulmak istediginiz id yi giriniz");

string id = Console.ReadLine();



string ad = "sa";
string soyad = "xxx";

Console.WriteLine("kullanici Adi: "+ad+", kullanci Soyad: "+ soyad);
Console.WriteLine($"kullainici Adi: {ad} , kulasi soyad: {soyad}");

Customers customerBulLınq =
   dbBaglan.Customers
   .FirstOrDefault(x => x.CustomerId.Equals(id));

Customers cBulLNative =
    dbBaglan.Customers
.FromSqlInterpolated($"select * from Customers where CustomerId = {id}")
.FirstOrDefault();

//if (cBulLNative != null) {
//    Console.WriteLine("hata username zaten kayitli");
//}


Console.WriteLine("aaa");
