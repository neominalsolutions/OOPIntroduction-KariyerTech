using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  internal class WaterInvoice : Invoice, IindexReadingCost
  {
    public WaterInvoice(double unitPrice) : base(unitPrice)
    {
    }

    public override string InvoiceType { get; set; } = "Su Faturası";
    public float indexReadingCost { get; set; }

    public override decimal DebitCost()
    {
      // son ödeme tarihi üzerinden 7 gün geçtikten sonra cezai işlem uygulanır. %2 cezai işlem
      if(DateTime.Now > DueDate.AddDays(7))
      {
        return base._usageCostCalculation() * (decimal)0.02;
      }

      return 0;
      
    }

    /// <summary>
    /// Interface based polymorphism
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void Pay()
    {
      throw new NotImplementedException();
    }
  }
}
