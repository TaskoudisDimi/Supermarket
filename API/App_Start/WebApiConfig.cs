using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            //Route templates are checked in order, first /api/{controller}/{id}
            //route template: /api/{controller}/{id}
            //MapHttpAttributeRoutes: enables attribute routing
            config.MapHttpAttributeRoutes();

            //config.Routes: route table or route collection of type HttpRouteCollection
            //DefaultApi route is added in the route table using MapHttpRoute() extension method
            //MapHttpRoute extension method internally creates a new instance of IHttpRoute and adds it to an HttpRouteCollection
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));


        }
    }
}
