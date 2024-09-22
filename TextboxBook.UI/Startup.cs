using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TextbokBook.Business.Abstract;
using TextbokBook.Business.Concrete;
using TextboxBook.Dal.Abstract;
using TextboxBook.Dal.Concrete;
using TextboxBook.Dal.Concrete.EntityFramework;
using TextboxBook.UI.Identity;

namespace TextboxBook.UI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer("Server=DESKTOP-2FDAH6B\\SQLEXPRESS;Database=TextBook;Trusted_Connection=true"));
            services.AddIdentity<ApplicationUser, ApplicationRole>().AddEntityFrameworkStores<ApplicationIdentityDbContext>().AddDefaultTokenProviders();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 6;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;

            });
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
                options.Cookie.HttpOnly = true;
                options.Cookie.Name = "EBookCookie";
                options.ExpireTimeSpan = TimeSpan.FromHours(1);

            });

            services.AddScoped<IBookService, BookManager>(); services.AddScoped<IBookDal, BookDal>();
            services.AddScoped<ICategoryService, CategoryManager>(); services.AddScoped<ICategoryDal, CategoryDal>();
            services.AddScoped<IAuthorService, AuthorManager>(); services.AddScoped<IAuthorDal, AuthorDal>();
            services.AddScoped<ILanguageService, LanguageManager>(); services.AddScoped<ILanguageDal, LanguageDal>();
            services.AddScoped<IPublisherService, PublisherManager>(); services.AddScoped<IPublisherDal, PublisherDal>();
            services.AddScoped<ICountryService, CountryManager>(); services.AddScoped<ICountryDal, CountryDal>();
            services.AddScoped<IGenderService, GenderManager>(); services.AddScoped<IGenderDal, GenderDal>();
            services.AddScoped<ICartService, CartManager>(); services.AddScoped<ICartDal, CartDal>();
            services.AddScoped<ICommentService, CommentManager>(); services.AddScoped<ICommentDal, CommentDal>();
            services.AddScoped<IOrderService, OrderManager>(); services.AddScoped<IOrderDal, OrderDal>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}", defaults: new { controller = "home", action = "index" });
            });
        }
    }
}
