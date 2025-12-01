using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SOA.features.auth.repositories;
using SOA.features.auth.services;
using SOA.features.auth.utils;
using SOA.features.property.admin.repository;
using SOA.features.property.admin.services;
using SOA.features.property.client.repository;
using SOA.features.property.client.services;
using SOA.features.shared.services;
using SOA.Features.Location.Repository;
using SOA.Features.Location.Services;
using SOA.middleware;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// --------------------------------------
// DATABASE
// --------------------------------------
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// --------------------------------------
// JSON OPTIONS
// --------------------------------------
builder.Services.AddControllers()
    .AddJsonOptions(opt =>
    {
        opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        opt.JsonSerializerOptions.WriteIndented = true;
        opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

// --------------------------------------
// SWAGGER
// --------------------------------------
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// --------------------------------------
// CORS (ALLOW ALL)
// --------------------------------------
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .WithOrigins("http://localhost:3000") 
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
    );
});

// --------------------------------------
// DEPENDENCY INJECTION
// --------------------------------------
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<CookieService>();
builder.Services.AddScoped<JwtService>();
builder.Services.AddScoped<PaginationService>();
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<QueryFilterService>();
builder.Services.AddScoped<ClientQueryFilterService>();
builder.Services.AddScoped<LocationService>();
builder.Services.AddScoped<LocationRepository>();
builder.Services.AddScoped<TokenRepository>();
builder.Services.AddSingleton<EmailService>();
builder.Services.AddScoped<TokenService>();
builder.Services.AddScoped<PropertyClientService>();
builder.Services.AddScoped<PropertyAdminRepository>();
builder.Services.AddScoped<PropertyAdminService>();
builder.Services.AddScoped<PropertyClientRepository>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<SOA.features.auth.utils.UserContextService>();
builder.Services.AddScoped<UserContextService>();

// --------------------------------------
// JWT
// --------------------------------------
#pragma warning disable CS8604 // Posible argumento de referencia nulo
var key = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]);
#pragma warning restore CS8604 // Posible argumento de referencia nulo

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(key)
    };

    options.Events = new JwtBearerEvents
    {
        OnMessageReceived = context =>
        {
            var token = context.Request.Cookies["TOKEN"];
            if (!string.IsNullOrEmpty(token))
                context.Token = token;

            return Task.CompletedTask;
        }
    };
});

builder.Services.AddAuthorization();

// --------------------------------------
// BUILD APP
// --------------------------------------
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ExceptionMiddleware>();

// CORS VA AQUÍ (fuera del JWT)
app.UseCors("AllowAll");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
