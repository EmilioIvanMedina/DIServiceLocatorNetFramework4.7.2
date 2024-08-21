using System.Web.Mvc;

namespace DIServiceLocatorPresentation.App_Start
{
    public static class ServiceLocator
    {
        public static T GetService<T>()
        {
            return (T)DependencyResolver.Current.GetService(typeof(T));
        }
    }
}