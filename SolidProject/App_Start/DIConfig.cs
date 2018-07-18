using SolidProject.Controllers;
using SolidProject.Entities;
using SolidProject.Entities.Repository.Implementation;
using SolidProject.Entities.Repository.Interface;
using SolidProject.Service.Implementation;
using SolidProject.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Injection;

namespace SolidProject.App_Start
{
    //unity configuration class
    public static class DIConfig
    {
        public static void ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerService(container);
            DependencyResolver.SetResolver(new unityDependencyResolver(container));
        }

        private static void registerService(IUnityContainer container)
        {
            container.RegisterType<IMembersService, MembersService>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }

    //Unity reslover
    public class unityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _IUnityContainer;

        public unityDependencyResolver(IUnityContainer UnityContainer)
        {
            _IUnityContainer = UnityContainer;
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _IUnityContainer.Resolve(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _IUnityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}