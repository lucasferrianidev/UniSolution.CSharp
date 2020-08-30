using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UniSolution.Models.Repositories;
using Ninject;
using System.Web.UI.WebControls;
using UniSolution.Models;
using UniSolution.Controllers;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace UniSolution
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web
            config.EnableCors();

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = System.Web.Http.RouteParameter.Optional }
            );

            // no chrome estava transformando em xml, dessa forma tenho certeza que que conseguirei transformar em json no client
            config.Formatters.JsonFormatter.SupportedMediaTypes
                .Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
