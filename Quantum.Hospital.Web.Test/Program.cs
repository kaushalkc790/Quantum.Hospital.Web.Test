using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NEAPES.UI.Components.Extensions;
using Quantum.Hospital.Web.Test;
using Quantum.Hospital.Web.Test.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddNEAPESUI();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IUserService, UserService>();
await builder.Build().RunAsync();
