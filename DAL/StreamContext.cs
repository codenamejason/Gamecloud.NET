using System;

namespace DAL
{
    public class StreamContext 
  {
      public StreamContext()
      {
      }

      public static StreamContext Create()
      {
        return new StreamContext();
      }
  }
}
