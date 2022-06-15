// See https://aka.ms/new-console-template for more information
using OOPIntroduction.Models;

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

Invoice i = new Invoice(unitPrice:3.2);
i.FirstIndex = 100; // m3
i.LastIndex = 125;
Console.WriteLine($"Fatura Tutarı : {i.UsageCost.ToString()}");


ElectricInvoice e = new ElectricInvoice(unitPrice: 3.2,energyCost:2.3M);
e.FirstIndex = 100; // m3
e.LastIndex = 125;
Console.WriteLine($"Fatura Tutarı : {e.UsageCost.ToString()}");

Console.ReadLine();


//Person p4 = new Person();
