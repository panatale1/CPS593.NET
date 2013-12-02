using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using DataLayer.Models;
namespace WebMVC
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();



            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Contact>("OdataContacts");
            builder.EntitySet<Address>("Address");
            builder.EntitySet<ContactMethod>("ContactMethod");
            builder.EntitySet<Keyword>("Keywords");
            config.Routes.MapODataRoute("odata", "odata", builder.GetEdmModel());


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
