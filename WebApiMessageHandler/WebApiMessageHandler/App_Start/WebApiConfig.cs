using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiMessageHandler.Models;

namespace WebApiMessageHandler
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web
            config.MessageHandlers.Add(new MessageHandler1());
            config.MessageHandlers.Add(new MessageHandler2());
            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
