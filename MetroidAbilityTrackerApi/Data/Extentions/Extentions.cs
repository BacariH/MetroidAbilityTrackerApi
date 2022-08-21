namespace MetroidAbilityTrackerApi.Data.Extentions
{
    public static class Extentions
    {
        public static void CreateDbIfNotExists(this IHost host)
        {
            {
                // this method allows us to be able to call the context to any controller
                using (var scope = host.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;
                    var context = services.GetRequiredService<MetroidAbilityTrackerApiContext>();
                    context.Database.EnsureCreated();
                    DbInitializer.Seed(context);
                }
            }
        }
    }
}
