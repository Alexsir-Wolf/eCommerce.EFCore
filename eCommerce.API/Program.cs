using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddControllers().AddJsonOptions(x =>
	x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

builder.Services.AddSwaggerGen(s =>
{
	s.SwaggerDoc("v1", new OpenApiInfo
	{
		Version = "v1",
		Title = "API de estudos sobre Entity Framework Core",
		Description = "Entity Framework Core API Swagger",
		Contact = new OpenApiContact
		{ 
			Name = "Alex Freitas", 
			Email = "freitas.alex.soares@outlook.com", 
			Url = new Uri("https://github.com/Alexsir-Wolf/eCommerce.EFCore") 
		},
	});

	// Set the comments path for the Swagger JSON and UI.
	var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
	var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
	s.IncludeXmlComments(xmlPath);
});

builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
	builder
		.WithOrigins("*")
		.AllowAnyMethod()
		.AllowAnyHeader();
}));

builder.Services.AddHttpContextAccessor();

builder.Services.Configure<RouteOptions>(options => { options.LowercaseUrls = true; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x => x
	.AllowAnyMethod()
	.AllowAnyHeader()
	.SetIsOriginAllowed(origin => true)
	.AllowCredentials());

app.Run();
