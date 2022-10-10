namespace MovieCritters.MVC.Configurations
{
    public static class WebAppConfig
    {
        public static void AddMVCConfiguration(this IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        public static void UseMVCConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseMigrationsEndPoint();
            
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseIdentityConfiguration();
        }
    }
}