using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PhongKham.Core.Interfaces;
using PhongKham.Infrastructure.Data.Context;
using PhongKham.Infrastructure.Repository;
using PhongKham.Infrastructure.UnitOfWork;
using PhongKham.WebApp.Services;

namespace PhongKham.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /*
            services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                options.RootDirectory = "/Pages/Manager";
            });
            */
            ConfigureAspnetRunServices(services);
            ConfigureDatabases(services);
            services.AddRazorPages();
            /*
            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #endregion
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PhongKhamDbContext phongKhamDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            PhongKhamContextSeed.SeedAsync(phongKhamDbContext).Wait();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                /*
                endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Client}/{action=Index}/{id?}");
                */
            });
        }
        private void ConfigureAspnetRunServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddScoped<IRazorRenderService, RazorRenderService>();
            //Appointment
            services.AddTransient<IAppointmentRepository, AppointmentRepositoryAsync>();
            services.AddTransient<AppointmentService>();
            //Invoice
            services.AddTransient<IInvoiceRepository, InvoiceRepositoryAsync>();
            services.AddTransient<InvoiceService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
        public void ConfigureDatabases(IServiceCollection services)
        {
            // use in-memory database

            services.AddDbContext<PhongKhamDbContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));

            //// use real database
            //services.AddDbContext<AspnetRunContext>(c =>
            //    c.UseSqlServer(Configuration.GetConnectionString("AspnetRunConnection"), x => x.MigrationsAssembly("AspnetRun.Web")));
        }
    }
}
