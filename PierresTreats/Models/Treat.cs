using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace PierresTreats.Models
{
  public class Treat 
  {
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public List<FlavorTreat> JoinEntities { get; set; } 
    public ApplicationUser User { get; set; }
  }
}  