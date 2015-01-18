namespace T4Enhanced.SampleClasses
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class Order
  {
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string OrderNumber { get; set; }
    public Address CompanyAddress { get; set; }
    public Address DeliveryAddress { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
  }
}
