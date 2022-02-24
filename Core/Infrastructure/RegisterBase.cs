using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public abstract class RegisterBase
    {
        public virtual IServiceCollection DoRegister(IServiceCollection services)
        {
            return services;
        }
    }
}
