using CargosRest.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace CargosRest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute(origins: "http://localhost:4200", headers: "*", methods: "*");
            //config.EnableCors(cors);

            //var constraints = new { httpMethod = new System.Web.Http.Routing.HttpMethodConstraint(HttpMethod.Options) };
            //config.Routes.IgnoreRoute("OPTIONS", "*pathInfo", constraints);
            //config.SetCorsPolicyProviderFactory(new CorsPolicyFactory());
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
