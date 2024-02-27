using BlazorApp6.Components;
using Syncfusion.Blazor;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<HttpClient>(factory => new HttpClient(new HttpClientHandler()
{
    ServerCertificateCustomValidationCallback = (HttpRequestMessage m, System.Security.Cryptography.X509Certificates.X509Certificate2 f, System.Security.Cryptography.X509Certificates.X509Chain x, System.Net.Security.SslPolicyErrors d) => true
}));
builder.Services.AddSyncfusionBlazor();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
