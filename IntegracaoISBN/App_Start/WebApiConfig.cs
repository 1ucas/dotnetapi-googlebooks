using System.Net.Http.Headers;
using System.Web.Http;
using IntegracaoISBN.injetctor;
using Swashbuckle.Application;
using SimpleInjector.Integration.WebApi;

namespace IntegracaoISBN
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Routes.MapHttpRoute(
                name: "swagger_root",
                routeTemplate: "",
                defaults: null,
                constraints: null,
                handler: new RedirectHandler((message => message.RequestUri.ToString()), "swagger"));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            // Injetor de dependências
            InjectorDependency.Iniciar();
            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(InjectorDependency.Container);
        }
    }
}
