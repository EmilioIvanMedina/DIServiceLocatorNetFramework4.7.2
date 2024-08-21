using DIServiceLocatorInfrastructure.Interfaces;

namespace DIServiceLocatorInfrastructure.Implementations
{
    public class SampleService : ISampleService
    {
        public string GetName()
        {
            return "the name";
        }
    }
}
