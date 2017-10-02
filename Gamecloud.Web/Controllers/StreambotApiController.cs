using Gamecloud.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Gamecloud.Web.Controllers
{
    public class StreambotApiController : ApiController
    {
    private ApplicationUserManager _userManager;

    public StreambotApiController()
    {
    }

    public StreambotApiController(ApplicationUserManager userManager)
    {
      UserManager = userManager;
    }

    public ApplicationUserManager UserManager
    {
      get
      {
        return _userManager ?? HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
      }
      private set
      {
        _userManager = value;
      }
    }

    // GET api/LoadStreambotViewModel
    public GetViewModel Get()
    {
      var user = UserManager.FindById(User.Identity.GetUserId());
      return new GetViewModel() { Hometown = user.Hometown };
    }
   


  }
}
