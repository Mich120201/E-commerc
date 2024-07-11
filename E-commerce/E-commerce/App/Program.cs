using Azure.Storage.Blobs;
using Checkout;
using ecommerce;
using ecommerce.Components;
using ecommerce.Database.Blob;
using ecommerce.Database.DBContext;
using Microsoft.EntityFrameworkCore;
using ILogger = Microsoft.Extensions.Logging.ILogger;
using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());

ILogger logger = factory.CreateLogger("Program");
ErrorHandler errorHandler = new(logger);

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//builder.Services.AddEntityFrameworkMySql();
builder.Services.AddControllers();
builder.Services.AddBlazorBootstrap();

string? CheckoutPK = builder.Configuration["Checkout_PK"];

string? BlobConnectionString = builder.Configuration["Blob_Connection_String"];

string? DbconnectionString = builder.Configuration["Db_Connection_String"];

if (DbconnectionString != null)
{
    try
    {
        builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(DbconnectionString, ServerVersion.AutoDetect(DbconnectionString)));
        builder.Services.AddSingleton<BlobConfig>()
            .AddSingleton(x => new BlobServiceClient(BlobConnectionString))
            .AddSingleton(x => new BlobClientOptions());
        ICheckoutApi api = CheckoutSdk.Builder()
            .StaticKeys()
            .SecretKey(CheckoutPK)
            .Environment(Checkout.Environment.Sandbox)
            .HttpClientFactory(new DefaultHttpClientFactory())
            .Build();
        builder.Services.AddSingleton(api);
    }
    catch (Exception ex)
    {
        errorHandler.NewException(ex);
    }
}
else
{
    errorHandler.NewException(new Exception("Void connection string. Unable to connect to database"));
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();
/*
app.MapControllerRoute(
    name: "product",
    pattern: "{controller=Product}");

app.MapControllerRoute(
    name: "productoption",
    pattern: "{controller=ProductOption}");

app.MapControllerRoute(
    name: "thumbimage",
    pattern: "{controller=ThumbImage}");

app.MapControllerRoute(
    name: "option",
    pattern: "{controller=Option}");
*/

app.MapControllerRoute(
    name: "default",
    pattern: "controller"
    );


app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

errorHandler.RiseExceptions();

app.Run();