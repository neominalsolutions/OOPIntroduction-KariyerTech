using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  /// <summary>
  /// Fatura nesnemiz (elektrik,su faturası,doğalgaz faturası)
  /// Katılımın amacı ortak davranışları (behaviour) ve ortak özellikleri (property) kullanabilecğimiz bir yapı inşaa etmek. Base class ile tanımlayacaz.
  /// abstract sınıflar abstract üyeler ile çalışabilirler. Nasıl bir davranış yada özellik göstereceğiniz bilmedğimiz class içerisinde method ve propertyleri abstract tanımlayabilir.
  /// </summary>
  public abstract class Invoice
  {

    private double _unitPrice;

    /// <summary>
    /// yani abstract üyelerin bodysi bulunmaz değer atamasını abstract sınıf içerisinde yapamazsınız ve abstract üyeler kalıtım alınan sınıfalara uygulanması zorunludur.
    /// </summary>
    public abstract string InvoiceType { get; set; }

    /// <summary>
    /// Son ödeme tarihi son ödeme tarihi geçtiğinde o zaman farklı tipte faturalara göre ceza uygulaması yapılır.
    /// </summary>
    public DateTime DueDate { get; set; }



    /// <summary>
    /// bu sınıfı oluşturuken olmazsa olmaz zorunlu değerleri constructor üzerinden gönderelim.
    /// </summary>
    /// <param name="unitPrice"></param>
    public Invoice(double unitPrice)
    {
      if(unitPrice <= 0)
      {
        _unitPrice = 1;
      }

      this._unitPrice = unitPrice;
    }

    /// <summary>
    /// Fatura Tutarı
    /// </summary>
    public decimal UsageCost { 
      get 
      {
        return this._usageCostCalculation();

      } 
    }

    /// <summary>
    /// Kalıtım ile bu hesaplamayı ezip yeni bir değeri set etmem lazım ve bunu yaparken encapsulation bozmadan bu logici içeride saklamam lazım.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    protected virtual decimal _usageCostCalculation()
    {

      if (LastIndex <= FirstIndex)
      {
        throw new Exception("Son girdi ilk girdi değerinden düşük olamaz");
      }

      return (decimal)(LastIndex - FirstIndex) * (decimal)_unitPrice;
    }

    /// <summary>
    /// Faturanın ceza bedeli
    /// Fatura ceza bedelinin nasıl hesaplanacağına dair hiçbir bilgim. Bunun ile ilgili herhangi bir hesaplama algoritması kafamda oturmuyor. Böyle durumlar için abstract method kullanırız.
    /// </summary>
    public abstract decimal DebitCost();

    /// <summary>
    /// İlk Index
    /// </summary>
    public double FirstIndex { get; set; }


    /// <summary>
    /// Son Index
    /// </summary>
    public double LastIndex { get; set; }



  }
}
