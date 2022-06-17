// See https://aka.ms/new-console-template for more information
using OOPIntroduction.Models;
using System.Reflection;

/*
Console.WriteLine("Hello, World!");

// p1 nesne (object)
// Person User Defined Type blue-print
Person p1 = new Person(); // instance alma örnek oluşturma. Ram Heap denilen bir bölgede p1 adında bir nesne referansı oluşuyor.
p1.FirstName = "Ali";
p1.LastName = "Tan";
p1.IdentityNumber = "324324324324";


// Garbage Collector kullanılamayan nesne instanceları ramden belirli zaman aralıklarında c# otomatik temizlenir.


Person p2 = new Person();
p2.FirstName = "Ahmet";
p2.LastName = "Tan";
p2.IdentityNumber = "32432324324";

*/


// Nesne ramde değer ile birlikte oluşmuş oluyor.
// çocuk saçlı doğuyor.
Person p3 = new Person(firstName:"Ayşe",lastName:"Tan");
p3.Nationality = "TC";
//p3.IdentityNumber = "24Bwd4355";
p3.IdentityNumber = "12345678901";

// string interpolation
Console.WriteLine($"id: { p3.IdentityNumber} name: {p3.FirstName}");
//Console.WriteLine("id " + String.Format("{0},{1}",p3.IdentityNumber));
Console.ReadLine();



// Kalıtım
// abstract sınıf ile başka nesneleri türetecek onlara örnek teşkil edecek klavuz bir sınıf oluşturuyoruz. Abstract sınıfların instance alınmıyor.

//Invoice i = new Invoice(unitPrice:3.2);
//i.FirstIndex = 100; // m3
//i.LastIndex = 125;
//Console.WriteLine($"Fatura Tutarı : {i.UsageCost.ToString()}");


ElectricInvoice e = new ElectricInvoice(unitPrice: 3.2,energyCost:2.3M);
e.FirstIndex = 100; // kwatt
e.LastIndex = 125;
e.DueDate = DateTime.Now.AddDays(-1);

Console.WriteLine($"Fatura Tipi: {e.InvoiceType} Ceza Tutarı: {e.DebitCost()}, Fatura Tutarı {e.UsageCost}");




WaterInvoice w = new WaterInvoice(unitPrice: 2.1);
w.FirstIndex = 100;
w.LastIndex = 350;
// 6/10/2022 Borcu ödemem lazım 7 gün borç vadesi var bundan dolayı cezaya girmemesi en geç 13/10/2022 ödememiş olmam lazım
w.DueDate = DateTime.Now.AddDays(-10);
var p =  w.DebitCost();

Console.WriteLine($"Fatura Tipi: {e.InvoiceType} Ceza Tutarı: {p}, Fatura Tutarı {w.UsageCost}");


/// <summary>
/// Reflection konusu uygulama çalışma zamanında uygulamaya müdehale etmemizi sağlayan bir kodlama tekniği sağlar.
/// </summary>
var type = typeof(IEnvironmentalTax);
var types = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p));



//Invoice c = new WaterInvoice(unitPrice: 3.4F);



Console.ReadLine();


//Person p4 = new Person();
