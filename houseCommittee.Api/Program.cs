using houseCommittee.core.IRepositories;
using houseCommittee.core.IService;
using houseCommittee.core.repositoriesI;
using houseCommittee.data;
using houseCommittee.data.repositories;
using houseCommittee.service.servies;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBuildingService, BuildingServies>();
builder.Services.AddScoped<IHouseCommitteeService, HouseCommitteeServies>();
builder.Services.AddScoped<IMessageService, MessageServies>();
builder.Services.AddScoped<ITenantService, TenantServies>();

builder.Services.AddScoped<ITenantRepository,TenantRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<IHouseCommitteeRepository, HouseCommitteeRepository>();
builder.Services.AddScoped<IMessageRepository, MessageRepository>();

builder.Services.AddDbContext<DataContext>();
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
app.Run();