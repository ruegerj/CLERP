using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Conventions
{
    public class GroupByApiRootConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNamespace = controller.Attributes.OfType<RouteAttribute>().FirstOrDefault();
            var apiVersion = controllerNamespace?.Template?.Split('/')?.First()?.ToLower() ?? "default";

            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
