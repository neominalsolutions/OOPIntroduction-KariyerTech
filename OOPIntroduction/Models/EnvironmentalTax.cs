using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{

  /// <summary>
  /// interfalerdeki üyelere public keyword yazmayız interface'in tüm üyeleri zaten publictir.
  /// Interfaclerdeki üyeler abstract üyelere benzer. body bulunmaz herhangi bir değer set edemezsiniz. veya methodun içeriğini yazamasınız.  
  /// C# da multi-inheritance verilemeyen durumlarda sınıflara belirli ortak yetenekleri interfaceler vasıtası ile kazandırabiliriz. C# interfaceler I ile başlar. Interface instance alınmaz. Interface'i interface yapan onu bir sınıfa özellik kazandırması.
  /// </summary>
  public interface IEnvironmentalTax
  {
    float EnvironmentalCleaningTaxAmount { get; set; }
  }

  public class EnvironmentalTax
  {
    public float EnvironmentalCleaningTaxAmount { get; set; } = 0.04F;

  }
}
