using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Notifications.Infrastructure
{
    public class JwtConfiguration
    {
        public static JwtBearerEvents BearerEvents
          => new JwtBearerEvents
          {
              OnMessageReceived = context =>
              {
                  var accessToken = context.Request.Query["access_token"];

                  var path = context.HttpContext.Request.Path;
                  if (!string.IsNullOrEmpty(accessToken) &&
                      path.StartsWithSegments("/notifications"))
                  {
                      context.Token = accessToken;
                  }

                  return Task.CompletedTask;
              }
          };
    }
}
