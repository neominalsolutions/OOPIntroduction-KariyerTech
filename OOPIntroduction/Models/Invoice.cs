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
  /// </summary>
  public class Invoice
  {

    private double _unitPrice;
   

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
    /// İlk Index
    /// </summary>
    public double FirstIndex { get; set; }


    /// <summary>
    /// Son Index
    /// </summary>
    public double LastIndex { get; set; }



  }
}
