var builder = WebApplication.CreateBuilder(args);
//using scopes to make it organized
{
    builder.Services.AddControllers();
}

var app = builder.Build();

{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}


