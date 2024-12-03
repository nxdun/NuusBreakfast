var builder = WebApplication.CreateBuilder(args);
//using scopes to make it organized
{
    builder.Services.AddControllers();
    //Add IBreakfastService as a singleton only allowing one instance of the service
    //AddSingleton : every interface request will return the same instance created
    //AddScoped : first request will create an instance and every subsequent request will return the same instance
    //AddTransient : every request will create a new instance
    builder.Services.AddSingleton<IBreakfastService, BreakfastService>();
}

var app = builder.Build();

{
    app.UseExceptionHandler("/error"); //error handler
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


