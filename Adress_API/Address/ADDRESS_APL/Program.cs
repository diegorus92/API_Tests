using ADDRESS_DAL.Data;
using ADDRESS_DAL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
insertContacts();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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




void insertContacts()
{
    using(var context = new AddressAppContext())
    {
        var contact1 = new Contact("Ruben", "Gomez", new DateTime(1993, 4, 22), "3624878900");
        var contact2 = new Contact("Carlos", "Ramirez", null, null, null);

        context.Contacts.Add(contact1);
        context.Contacts.Add(contact2);

        context.SaveChanges();
    }
}