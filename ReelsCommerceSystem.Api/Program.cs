using ReelsCommerceSystem.Api.DependencyInjectionExtensions;
using ReelsCommerceSystem.Api.Middlewares;
using ReelsCommerceSystem.Api.Middlewares.MiddlewaresExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IValidationMessageProvider, JsonValidationMessageProvider>();

builder.Services.AddValidationMiddleware();

builder.Services.AddOpenApi();

builder.Services.AddApplicationCorsConfig(builder.Configuration);

var app = builder.Build();


app.UseExceptionHandlingMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(op=>
    op.SwaggerEndpoint("/openapi/v1.json", "ReelsCommerceSystem"));
}


app.UseStatusCodePages(async context =>
{
    if (context.HttpContext.Response.StatusCode == 404)
    {
        context.HttpContext.Response.Redirect("/Api/Error/NotFound");
    }
});

app.UseCors("AppCorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
