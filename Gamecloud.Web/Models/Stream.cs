using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gamecloud.Web.Models
{
  public class Stream
  {
    public int Id { get; set; }

    public string StreamName { get; set; }

    public ApplicationUser StreamApplicationUser { get; set; }




  }
}