using System;
using System.Reflection;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Attributes;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace ProgramacionAvanzada
{
    class Program
    {
        static void Main(string[] args)
        {
            //SuscriptorCalculadoraVirtual calculadoraVirtual = new SuscriptorCalculadoraVirtual(3, 2);

            // calculadoraVirtual.OperacionSuma();
            //calculadoraVirtual.OperacionResta();

            //Summary summary = BenchmarkRunner.Run<Ejemplo>();
            //Console.WriteLine(summary);

            //            var assembly = Assembly.LoadFrom(@"/Users/eduardogonzalez/Documents/Practicas-CSharp/ProgramacionAvanzada/PrintAll/bin/Release/net5.0/PrintAll.dll");

            //            foreach(var type in assembly.GetTypes())
            //            {
            //                Console.WriteLine($"type:{type.Name}");
            //                Console.WriteLine("====================================");
            //                var instance = Activator.CreateInstance(type);
            //                foreach(var field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            //                {
            //                    Console.WriteLine($"Field: {field.Name}");
            //                    field.SetValue(instance, "Frodo");
            //                }
            //                Console.WriteLine("====================================");

            //                foreach(var method in type.GetMethods(BindingFlags.Public |
            //BindingFlags.NonPublic|BindingFlags.Instance | BindingFlags.DeclaredOnly).Where(m=>!m.IsSpecialName))
            //                {
            //                    Console.WriteLine($"Method: {method.Name}");
            //                    if (method.GetParameters().Length > 0)
            //                    {
            //                        method.Invoke(instance, new[] { "Bilbo" });

            //                    }
            //                    else if(method.ReturnType.Name != "Void")
            //                    {
            //                        var returnedValue = method.Invoke(instance, null);
            //                        Console.WriteLine($"Returned value from method: {returnedValue}");
            //                    }
            //                    else
            //                    {
            //                        method.Invoke(instance, null);
            //                    }


            //                }
            //                Console.WriteLine("====================================");
            //                foreach (var property in type.GetProperties())
            //                {
            //                    Console.WriteLine($"Property: {property.Name}");
            //                    var propertyValue = property.GetValue(instance);
            //                    Console.WriteLine($"Property value: {propertyValue}");
            //                }
            //            }

       CreateWebHostBuilder(args).Build().Run();
        }
        private static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration) { Configuration = configuration; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app)
        {
            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)); //Corregir esta configuración en producción

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chat");
            });
        }
    }
}
