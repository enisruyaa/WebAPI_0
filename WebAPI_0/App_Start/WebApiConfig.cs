using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebAPI_0
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Alt Taraftakş EnableCorsAttribute constractor argümanlarından ilkinin yılız olması tüm farklı projelerin bu API'ya bağlanmasına izin verdiğii bildirir ("www.enis.com","www.canberk.com"), ikinci argüman ise headers yani bir HTTPContext içerisinde taşınan bilgi başlıkları içerisinden hangi başlıkların request'te gitmesine izin veriliyor onu bildiriyor. 3.si methods siz hangi metotları dışarı açmak istiyorsunuz bunu belirtir.

           EnableCorsAttribute cors = new EnableCorsAttribute("*","*","*");

            config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
