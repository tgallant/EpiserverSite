using System.Web.Http;

public static class WebApiConfig
{
    public static void Register(HttpConfiguration configuration)
    {
        // configuration.MapHttpAttributeRoutes();

        configuration.Routes.MapHttpRoute(
            name: "TestApi",
            routeTemplate: "api/{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );
    }
}