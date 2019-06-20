using System.Collections.Generic;

namespace TinyIoC
{
    public class LazyFactory<T>
    {
        private readonly TinyIoCContainer _container;
        
        //todo make constructor private - bridge support needed

        public LazyFactory(TinyIoCContainer container)
        {
            _container = container;
        }

        //todo resolveOptions - named registrations fallback
        //todo resolveOptions - parameter resolution fallback
        //todo overloads of other relevant resolve methods
        
        
        public T GetInstance()
        {
            return (T) _container.Resolve(typeof(T));
        }
        
        public T GetInstance(string namedRegistrationKey)
        {
            return (T) _container.Resolve(typeof(T), namedRegistrationKey);
        }
        
        public T GetInstance(NamedParameterOverloads constructorParameterOverloads)
        {
            return (T) _container.Resolve(typeof(T), constructorParameterOverloads);
        }
        
        public T GetInstance(string namedRegistrationKey, NamedParameterOverloads constructorParameterOverloads)
        {
            return (T) _container.Resolve(typeof(T), namedRegistrationKey, constructorParameterOverloads);
        }
    }
}