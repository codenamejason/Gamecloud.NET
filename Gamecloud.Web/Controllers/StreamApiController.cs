using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gamecloud.Web.Models;

namespace Gamecloud.Web.Controllers
{
    public class StreamApiController : ApiController
    {
        public StreamApiController() { }

      // GET api/streams
      public List<Stream> GetStreams(int UserId)
      {
          var streams = new List<Stream>();

          return streams;
      }


    }
}
