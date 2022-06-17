using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  /// <summary>
  /// Index Okutma Bedeli
  /// </summary>
  internal interface IindexReadingCost
  {
    float indexReadingCost { get; set; }
    void Pay();
  }
}
