using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WA.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Category { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
    public string Colors { get; set; }
    public string Title { get; set; }
    public string DoorDescription { get; set; }
    public string DoorId { get; set; }
    public string Manufacturer { get; set; }
  }
}
