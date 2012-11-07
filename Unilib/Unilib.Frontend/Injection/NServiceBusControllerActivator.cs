using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Unilib.Frontend.Injection
{
    public class NServiceBusControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            return DependencyResolver.Current.GetService(controllerType) as IController;
        }
    }
}