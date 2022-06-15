using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntroduction.Models
{
  public class Person
  {

    /// <summary>
    /// Kimlik numarası doğru girildikten sonra üzerinden kimlik numarası değerini taşıyacak olan variable. IdentityNumber property değerini return ediyor. Field class içinde tanımlı private bir değişken olduğu için class dışına çıkarken public bir property ile çıkmak durumunda
    /// </summary>
    private string _identityNumber = string.Empty;

    /// <summary>
    /// Encapsulation Örneği. Bu methodu dışırıdan dolayı bir yol ile çağırıyoruz. Yazılımcı içeridik uyruğa göre kimlik oluşturma algoritması ile ilgilenmiyor.
    /// Kimlik Numarasını Uyruğa göre doğru girme algoritması var
    /// </summary>
    /// <param name="nationality"></param>
    /// <param name="identityNumber"></param>
    /// <exception cref="Exception"></exception>
    private void SetIdentityNumber(string nationality, string identityNumber)
    {

      if(string.IsNullOrEmpty(nationality))
      {
        throw new Exception("Kimlik numarası için uyruk girilmelidir");
      }

      if(nationality == "TC")
      {
        if(identityNumber.Length < 11 || identityNumber.Length > 11)
        {
          throw new Exception("TC No 11 karakter olmalıdır");
        }
        else
        {
          // bütün değerler numeric mi?
          bool isNumeric = true;

          foreach (var number in identityNumber)
          {
            if(!char.IsNumber(number))
            {
              isNumeric = false;
              break;
            }
          }

          if(!isNumeric)
          {
            throw new Exception("TC no numeric olmalıdır");
          } 
          else
          {
            _identityNumber = identityNumber;
          }
        } 
      }


    }

    // TC No
    public string IdentityNumber { get { return _identityNumber; } set {

        SetIdentityNumber(this.Nationality, value);
      
      } } 

    // auto property (public) tanımlanır.
    public string FirstName { get; set; }

    public string LastName { get; set; }

    /// <summary>
    /// Kişinin uyruğuna göre İdentity Number tanımlaması yapmasına izin vereceğiz. TC için 11 karakterden oluşmalıdır.  USA ise USA ile başlamalı ve 13 karakter uzunluğunda olmalıdır.
    /// </summary>
    public string Nationality { get; set; } 


    // Boş constructor deriz. C# gizli olarak her sınıfın bir boş contructor vardır. Eğer 2.bir constructor yazılırsa boş parametresiz halini yazmak zorundayız.
    public Person()
    {

    }

    /// <summary>
    /// Nesne ram üzerinde ilk oluşurken nesneden instance alınırken ilk çalışan method.
    /// </summary>
    public Person(string firstName,string lastName)
    {
      this.FirstName = firstName;
      this.LastName = lastName;
    }


    /// <summary>
    ///  Yıkıcı method (Destructure). Nesne ile işim bittiğinde nesneyi ramden temizleme işlemini yaptığımız method. Buna ihtiyaç duymuyoruz.
    /// </summary>
    ~Person()
    {

    }

  }
}
