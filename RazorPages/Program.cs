var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapRazorPages();

//    // Define a p�gina inicial
//    endpoints.MapGet("/", context =>
//    {
//        context.Response.Redirect("/Index");
//        return Task.CompletedTask;
//    });
//});

app.MapGet("/", async context => 
{
    context.Response.Redirect("/inicio");

    await Task.CompletedTask;
});

app.MapRazorPages();

app.Run();
