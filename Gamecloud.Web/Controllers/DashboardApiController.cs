using Gamecloud.Web.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Diagnostics.Contracts;

namespace Gamecloud.Web.Controllers
{
    public class DashboardApiController : ApiController
    {
      
    public DashboardApiController() { }

    private ApplicationUserManager UserManager { get; set; }

    public DashboardApiController(ApplicationUserManager userManager)
    {
      UserManager = userManager;
    }

    // GET api/DashboardApiController
    public DashboardViewModel GetDashboard()
    {
     // Contract.Ensures(Contract.Result<DashboardViewModel>() != null);

      var user = UserManager.FindById(User.Identity.GetUserId());

      return new DashboardViewModel()
      {
        UserName = user.UserName
      };

    }



    }
}
