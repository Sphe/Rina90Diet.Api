using AutoMapper;
using Common.Data.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rina90Diet.Data.FullDomain;
using Rina90Diet.Data.FullDomain.Bulk;
using Rina90Diet.Data.FullDomain.Infrastructure;
using Rina90Diet.Service;
using Rina90Diet.Service.BusinessImplService;
using Rina90Diet.Service.BusinessImplService.Contract;
using Rina90Diet.Service.Contract;
using Rina90Diet.Service.PersistenceService;
using Rina90Diet.Blockchain.Service.LycServiceContract;
using Rina90Diet.Blockchain.Service.LycServiceContract.Architecture;
using Rina90Diet.Blockchain.Service.KafkaMessager;
using Rina90Diet.Blockchain.Service.KafkaMessager.Contract;
using Serilog;
using System.Globalization;
using Microsoft.Extensions.Logging;
using System;
using Rina90Diet.Model.FullDomain;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.OpenApi.Models;

namespace Rina90Diet.Front.ApiWeb
{
    public class Startup
    {
        private readonly IHostingEnvironment _hostingEnv;

        //public IConfigurationRoot Configuration { get; }

        public bool IsDebugEnv { get; set; } = false;

        public Startup(IHostingEnvironment env)
        {
            _hostingEnv = env;

            //Configuration = Program.MainConfig;

            var seqUrl = ""; //Configuration["SeqServer"];

            if (string.IsNullOrWhiteSpace(seqUrl))
            {
                seqUrl = "http://seq.rina90Diet.com";
            }

            Serilog.Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .Enrich.FromLogContext()
                .WriteTo.Seq(seqUrl)
                .CreateLogger();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();

            //dependency injection

            var connectionString = ""; //Configuration["ConnString"];

            //EF
            services.AddScoped(typeof(IDatabaseFactory<Rina90DietdbContext>), _ => new Rina90DietDbFullDomainDatabaseFactory(connectionString));

            services.AddScoped(typeof(IRina90DietDbFullDomainRepository<>), typeof(Rina90DietDbFullDomainRepositoryBase<>));

            services.AddScoped(typeof(IRina90DietDbFullDomainUnitOfWork), typeof(Rina90DietDbFullDomainUnitOfWorkBase));

            services.AddSingleton(typeof(MapperConfiguration), MappingRegistrar.CreateMapperConfig());

            //Services
            var kafkaUrl = "";  //Configuration["Kafka"];
            services.AddSingleton(typeof(IKafkaConfigFactory), _ => new KafkaConfigFactory(kafkaUrl));

            services.AddSingleton(typeof(IKafkaProducerConsumerFactory), typeof(KafkaProducerConsumerFactory));
            services.AddSingleton(typeof(IKafkaFacade), typeof(KafkaFacade));

            services.AddTransient(typeof(ICommonMessageService), typeof(CommonMessageService));

            services.AddTransient(typeof(ICustomerService), typeof(CustomerService));


            services.AddTransient(typeof(IRina90DietBulkOperator), typeof(Rina90DietBulkOperator));

            services.AddTransient(typeof(IDbContextService), typeof(DbContextService));

            services.AddTransient(typeof(IAttributeService), typeof(AttributeService));

            services.AddTransient(typeof(IGenericCrudService<,>), typeof(GenericCrudService<,>));

            services.AddSingleton(typeof(IRina90DietBusinessService), typeof(Rina90DietBusinessService));

            services.AddMvc();

            // ********************
            // Setup CORS
            // ********************
            var corsBuilder = new CorsPolicyBuilder();
            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            corsBuilder.AllowAnyOrigin(); // For anyone access.
            corsBuilder.AllowCredentials();

            services.AddCors(options =>
            {
                options.AddPolicy("SiteCorsPolicy", corsBuilder.Build());
            });

            services.AddSignalR();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Rina90Diet API", Version = "v1" });
                c.EnableAnnotations();
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IApplicationLifetime appLifetime, IServiceProvider serviceProvider)
        {
            var cultureInfo = new CultureInfo("en-US");

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            loggerFactory.AddSerilog();
            appLifetime.ApplicationStopped.Register(Serilog.Log.CloseAndFlush);

            //loggerFactory.AddConsole("" /* Configuration.GetSection("Logging") */);
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSignalR(routes =>
            {
                routes.MapHub<Rina90DietHub>("/rtllc");
            });

            app.UseMvc();
            app.UseCors("SiteCorsPolicy");

            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Rina90Diet API V1");
            });

        }
    }
}
