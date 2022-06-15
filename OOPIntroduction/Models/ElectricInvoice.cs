using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  public class ElectricInvoice : Invoice
  {
    private decimal _energyCost;
    private const double _taxAmount = 0.03;

    public ElectricInvoice(double unitPrice, decimal energyCost) : base(unitPrice)
    {
      _energyCost = energyCost;
    }

    protected override decimal _usageCostCalculation()
    {
      return (base._usageCostCalculation() + this._energyCost) * (1+(decimal)_taxAmount);
    }
  }
}
