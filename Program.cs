var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
// The default HSTS value is 30 days. You may want to change this for production scenarios, see 
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseRouting();

//app.UseAuthorization();

//app.MapStaticAssets();



//app.Use(async (context,next) =>
//{
//    await context.Response.WriteAsync("Welcome \n");
//    await next(context);
//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("PAKISTAN");
//});

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=User}/{action=About}/{id?}");

//app.MapControllers();
app.Map("/Home/Index", () => "Welcome to Home Page-Map");
app.MapGet("/Home/Index", () => "Welcome to Home Page-Get");
app.MapPost("/Home/Index", () => "Welcome to Home Page-Post");
app.MapPut("/Home/Index", () => "Welcome to Home Page-Put");
app.MapDelete("/Home/Index", () => "Welcome to Home Page-Delete");


app.Run();
