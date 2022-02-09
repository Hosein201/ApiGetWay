namespace Infrastructure
{
    /// <summary>
    /// Scoped: IoC container will create an instance of the specified service type once per request and will be shared in a single request.
    /// </summary>
    public interface IScopedDependency { }

    /// <summary>
    /// Transient: The IoC container will create a new instance of the specified service type every time you ask for it.
    /// </summary>
    public interface ITransientDependency { }

    /// <summary>
    /// Singleton: IoC container will create and share a single instance of a service throughout the application's lifetime.
    /// </summary>
    public interface ISingletonDependency { }
}
