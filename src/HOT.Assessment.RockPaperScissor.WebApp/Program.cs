using HOT.Assessment.RockPaperScissor.Core.Domain.Game;
using HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;
using HOT.Assessment.RockPaperScissor.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<IPaperRockScissorUseCase>(provider 
    => new PaperRockScissorUseCase(new GamePaperRockScissor()));


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