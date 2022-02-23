using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using OrderProcessing.Core.Attributes;
using OrderProcessing.Mapper.Commands.Permission;
using OrderProcessing.Mapper.Dto.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace OrderProcessing.Core.Middlewares
{
    public static class PermissionMiddleware
    {
        /// <summary>
        /// Get info of action that use UserAccessAttribute and insert with Mediator in db or caching
        /// </summary>
        /// <param name="serviceProvider">serviceProvider </param>
        /// <param name="type">type of current assembly </param>
        /// <returns></returns>
        public static Action UsePermission(IServiceProvider serviceProvider, Type type)
        {
            if (type is null)
                throw new ArgumentNullException("type is null in method usePermission");

            var mediatR = (IMediator)serviceProvider.GetRequiredService(typeof(IMediator));

            if (mediatR is null)
                throw new ArgumentNullException("mediatR is null in method usePermission");


            List<InsertPermissionDto> dtos = new();

            var controllers = Assembly.GetAssembly(type)
                                .GetTypes()
                                .Where(w =>
                                       !w.IsAbstract &&
                                       !w.IsInterface &&
                                        w.IsPublic &&
                                        w.IsSubclassOf(typeof(ControllerBase))).ToList();

            for (int c = 0; c < controllers.Count; c++)
            {
                var actions = Assembly.GetAssembly(controllers[c]).GetTypes()
                                      .SelectMany(t => t.GetMethods())
                                      .Where(m => m.GetCustomAttributes(typeof(UserAccessAttribute), false).Length > 0)
                                      .ToList();

                for (int a = 0; a < actions.Count; a++)
                {
                    var userAccessAttribute = (UserAccessAttribute)Attribute.GetCustomAttributes(actions[a], typeof(UserAccessAttribute)).FirstOrDefault();

                    dtos.Add(new InsertPermissionDto
                    {
                        ControllerName = controllers[c].Name,
                        ActionName = actions[a].Name,
                        Active = userAccessAttribute.Active,
                        RoleName = userAccessAttribute.Role.ToString(),
                        RoleCode = (int)userAccessAttribute.Role,
                        FullUrl = $"api/{controllers[c].Name}/{actions[a].Name}"
                    });
                }
            }

            PermissionInsertCommand command = new() { Permissions = dtos };
            Task.Run(() => mediatR.Send(command));
            return null;
        }
    }
}
