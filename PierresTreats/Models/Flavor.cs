using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; }
  }
}