using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  /// <summary>
  /// Invoice, IEnvironmentalTax
  /// </summary>
  public class GasInvoice : Invoice, IEnvironmentalTax
  {

    //public float EnvironmentalCleaningTaxAmount { get; set; } = 0.08F;

    public GasInvoice(double unitPrice) : base(unitPrice)
    {
    }

    public override string InvoiceType { get; set; } = "Doğalgaz Faturası";
    public float EnvironmentalCleaningTaxAmount { get; set; } = 0.08F;

    public override decimal DebitCost()
    {
      throw new NotImplementedException();
    }
  }
}
