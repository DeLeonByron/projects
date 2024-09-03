using ArithmeticCalculatorApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar CORS globalmente o solo para desarrollo
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAllOrigins",
            policyBuilder => policyBuilder.AllowAnyOrigin()
                                           .AllowAnyMethod()
                                           .AllowAnyHeader());
    });
}

// Agregar los servicios específicos de la aplicación
builder.Services.AddScoped<IArithmeticService, ArithmeticService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArithmeticCalculatorApi V1");
        c.RoutePrefix = string.Empty;
    });

    // Aplicar la política de CORS para ambiente de develop
    app.UseCors("AllowAllOrigins");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
