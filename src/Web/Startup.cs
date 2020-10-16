using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using Infrastructure.Data.Repository;
using Infrastructure.Data;
using ApplicationCore.Services;

namespace Web
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<ModelContext>();
			services.AddRazorPages();
			services.AddServerSideBlazor();
			services.AddHeadElementHelper();
			services.AddScoped(typeof(IAsyncIntIdRepository<>), typeof(ModelIntIdRepository<>));
			services.AddScoped(typeof(IAsyncStrIdRepository<>), typeof(ModelStrIdRepository<>));
		    services.AddScoped<IForexRepository, ForexRepository>();
			services.AddScoped<IForexService, ForexService>();
			services.AddScoped<IDepoRepository, DepoRepository>();
			services.AddScoped<IDepoService, DepoService>();
			services.AddScoped<ICurrencyRepository, CurrencyRepository>();
			services.AddScoped<ICurrencyService, CurrencyService>();
			services.AddScoped<IOrgsRepository, OrgsRepository>();
			services.AddScoped<IOrgsService, OrgsService>();
			services.AddScoped<IBooksRepository, BooksRepository>();
			services.AddScoped<IBooksService, BooksService>();
			services.AddScoped<IBrokersRepository, BrokersRepository>();
			services.AddScoped<IBrokersService, BrokersService>();
			services.AddScoped<IDealersRepository, DealersRepository>();
			services.AddScoped<IDealersService, DealersService>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapBlazorHub();
				endpoints.MapFallbackToPage("/_Host");
			});
		}
	}
}
