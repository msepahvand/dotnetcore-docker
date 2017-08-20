using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Autofac.Features.Variance;
using MediatR;
using StudentAPI.Core.Query;

namespace StudentAPI.Web.IoC
{
    public class MediatorModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // enables contravariant Resolve() for interfaces with single contravariant ("in") arg
            builder
                .RegisterSource(new ContravariantRegistrationSource());

            // mediator itself
            builder
                .RegisterType<Mediator>()
                .As<IMediator>()
                .InstancePerLifetimeScope();

            // request handlers
            builder
                .Register<SingleInstanceFactory>(ctx => {
                    var c = ctx.Resolve<IComponentContext>();
                    return t => { object o; return c.TryResolve(t, out o) ? o : null; };
                })
                .InstancePerLifetimeScope();

            // notification handlers
            builder
                .Register<MultiInstanceFactory>(ctx => {
                    var c = ctx.Resolve<IComponentContext>();
                    return t => (IEnumerable<object>)c.Resolve(typeof(IEnumerable<>).MakeGenericType(t));
                })
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(GetStudentByIdQuery).GetTypeInfo().Assembly).AsImplementedInterfaces(); // via assembly scan
        }
    }

}
