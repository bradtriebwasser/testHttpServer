var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Origin-Trial",@"A361VnHspG10hGbiaQDIsvFku3Ru41JD7MOYFzvVIuPquQqbKsYkK2OdpQglxpwhmHw9E13AGyLv/1jpPzi4lAIAAABeeyJvcmlnaW4iOiAiaHR0cDovL2xvY2FsaG9zdDo1MjEzIiwgImZlYXR1cmUiOiAiRnVsbHNjcmVlblBvcHVwV2luZG93cyIsICJleHBpcnkiOiAxNjk4MTkyMDcyfQ==");
    // Call the next delegate/middleware in the pipeline.
    await next(context);
});

app.UseFileServer();


app.Run();
