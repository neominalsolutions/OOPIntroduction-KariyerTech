using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  /// <summary>
  /// Abstract üyelerin kalıtım alınan sınıfalara uygulanmasına implementasyon diyoruz. abstract bir üye kalıtım alınan sınıfta implemente edildiğinde ovveride edilir.
  /// 
  /// ElectricInvoice : Invoice, EnvironmentalTax (C# Multi Inheritance desteklemez)
  /// Yani bir sınıf interface üzerinden bir çok yetenek kazanabilir. Multi Implementaion
  /// </summary>
  public class ElectricInvoice : Invoice, IEnvironmentalTax, IindexReadingCost
  {
    private decimal _energyCost;
    private const double _taxAmount = 0.03;

    // Çevre temizlik vergisi
    //public float EnvironmentalCleaningTaxAmount { get; set; } = 0.04F;

    public override string InvoiceType { get; set; } = "Elektirik Faturası";
    public float EnvironmentalCleaningTaxAmount { get; set; } = 0.04F;
    public float indexReadingCost { get; set; }

    public ElectricInvoice(double unitPrice, decimal energyCost) : base(unitPrice)
    {
      _energyCost = energyCost;
    }

    protected override decimal _usageCostCalculation()
    {
      return (base._usageCostCalculation() + this._energyCost) * (1+(decimal)_taxAmount);
    }

    /// <summary>
    /// DebitCost Cezai işlem uygulama prosedürü farklı fatura tipleri için farklı algoritmalar ile aynı method ismi ile çalışıyor.
    /// </summary>
    /// <returns></returns>
    public override decimal DebitCost()
    {
      // Son ödeme tarihi geçtiği andan itibaren fatura tutarının yüzde 5 kadar cezai işlem uygulanır.
      if (DueDate > DateTime.Now)
      {
        return this._usageCostCalculation() * (decimal)0.05;
      }

      return 0;
    }

    public void Pay()
    {
      throw new NotImplementedException();
    }
  }
}
