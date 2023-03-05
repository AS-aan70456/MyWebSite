using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentMvcProject.Service;
using TorrentMvcProject.Domain;
using Microsoft.EntityFrameworkCore;
using TorrentMvcProject.Domain.Reposetory;
using TorrentMvcProject.Domain.Reposetory.RepModel;
using TorrentMvcProject.Domain.Reposetory.interfeises;

namespace TorrentMvcProject{
    public class Startup{

        public IConfiguration Configuration { get; }
        public Startup(IHostEnvironment hostEnv) {
            Configuration = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("DBSettings.json").Build(); ;
        }

        public void ConfigureServices(IServiceCollection services){
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IallCategory, CategoryReposetory>();
            services.AddTransient<IallGameItem, GameItemReposetory>();
            services.AddTransient<IallComments, CommentsReposetory>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp =>)

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();

            services.AddControllersWithViews().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env){
            if (env.IsDevelopment())app.UseDeveloperExceptionPage();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            //{ ID ?}
            app.UseEndpoints(endpoints =>{
                endpoints.MapControllerRoute("categoryFilter", "Home/{action}/{Category}/{ID?}");
                endpoints.MapControllerRoute("categoryFilter", "Home/{action}/{leyer}/{ID?}");
                endpoints.MapControllerRoute("categoryFilter", "Home/{action}/{search}/{ID?}");
                endpoints.MapControllerRoute("categoryFilter", "Game/{action}/{Name?}");
                endpoints.MapControllerRoute("defult", "{controller=Home}/{action=Home}/{id?}");

            });

            
            using (var scowp = app.ApplicationServices.CreateScope()){
                GameItemReposetory RepGame = new GameItemReposetory(scowp.ServiceProvider.GetRequiredService<AppDbContext>());
                RepGame.SaveGameItem(new Domain.Entity.GameItem() {
                
                    name = "Frostpunk",
                    version = "v 1.6.1.51852.59618 + все DLC",
                    desc = "Frostpunk — компьютерная игра в жанре градостроительного симулятора и симулятор выживания[1], разработанная компанией 11 bit studios. Игра включает в себя элементы стимпанка и альтернативной истории. Название игры является неологизмом, придуманным её создателями, и получено путём объединения слов frost (англ. мороз) и steampunk (стимпанк).",
                    like = 21,
                    dizlike = 3,
                    mainImg = "/img/Frostpunk/GameImg.jpg",
                    img1 =    "/img/Frostpunk/f1.jpg",
                    img2 =    "/img/Frostpunk/f2.jpg",
                    img3 =    "/img/Frostpunk/f3.jpg",
                    img4 =    "/img/Frostpunk/f4.jpg",
                    puthToTorrent = "C:/Users/User/source/repos/TorrentMvcProject/TorrentMvcProject/wwwroot/img/Frostpunk/Torrent.torrent",
                    ReleaseDate = 2018,
                    developer = "11 bit studios",
                    languages = "Русский, Английский",
                    Windows = "7, 8, 10 (64-bit)",

                    CPU = "3.2 GHz Dual Core",
                    RAM = "4 GB",

                    videoCard = "GeForce GTX 660, Radeon R7 370 or equivalent with 2 GB of video RAM (DirectX: Версии 11)",
                    weight = 8,

                    teg = "Simulation/Strategy/Economy",

                });
            }
            //*/

        }
    }
}
