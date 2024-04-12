using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using WebAPI_Portfolio.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
MySqlConnection conn = new MySqlConnection();
conn.ConnectionString = "server=localhost;uid=root;password=redacted;database=test";
conn.Open();

MySqlCommand cmd = new MySqlCommand();
cmd.Connection = conn;
cmd.CommandType = CommandType.StoredProcedure;
cmd.CommandText = "get_values";
MySqlDataReader dr = cmd.ExecuteReader();

while (dr.Read())
{
    string s = dr.GetString("test");
}
dr.Close();
conn.Close();


//string conn = "server=localhost:3306;uid=root;pwd=redacted;database=test";


builder.Services.AddDbContext<ApiContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
