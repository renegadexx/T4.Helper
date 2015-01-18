namespace T4Enhanced.SampleClasses
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;

  public class OrderItem
  {
    public int Id { get; set; }	
    public Order Order { get; set; }
    public int ProductId { get; set; }
    public double Quantity { get; set; }
    public double Price { get; set; }
    public double Discount { get; set; }
  }
}
