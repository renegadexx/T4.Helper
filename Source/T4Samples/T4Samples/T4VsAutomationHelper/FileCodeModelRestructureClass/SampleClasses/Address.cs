namespace T4Enhanced.SampleClasses
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class Address 
  {
    public int Id { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    // Implementierung basiert auf Beispiel http://openbook.galileocomputing.de/csharp/kap27.htm
    public override int GetHashCode()
    {   
      return this.Id.GetHashCode();
    }

    public override bool Equals(object obj)
    {   
      Address address = (Address)obj;

      if (Id != address.Id)
        return (false);
      if (Street != address.Street)
        return (false);
      if (PostalCode != address.PostalCode)
        return (false);
      if (City != address.City)
        return (false);
      return (true);
    }

    public static bool operator ==(Address obj1, Address obj2)
    {
      return (obj1.Equals(obj2));
    }

    public static bool operator !=(Address obj1, Address obj2)
    {
      return (!obj1.Equals(obj2));
    }
  }
}
