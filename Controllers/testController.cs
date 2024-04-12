using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Portfolio.Models;
using WebAPI_Portfolio.Data;
using System.Data;
using WebAPI_Portfolio;
using MySql.Data.MySqlClient;
using System.Text.Json;
using System.Collections;

namespace WebAPI_Portfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {
        private readonly ApiContext _context;

        public testController(ApiContext context)
        {
            _context = context;
        }


        [Route("/")]
        [HttpGet]
        public string Get(int id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;password=Chips90!;database=houses";
            //conn.ConnectionString = "server=localhost;uid=public;password=publicpassword74?;database=houses";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "get_houses";
            MySqlDataReader dr = cmd.ExecuteReader();
            List<House> al = new List<House>();
            while (dr.Read())
            {
                al.Add(new House
                {
                    HouseID = dr.IsDBNull("houseId") ? null : dr.GetInt32("houseId"),
                    Address = dr.IsDBNull("address") ? null : dr.GetString("address"),
                    PropertyType = dr.IsDBNull("propertyType") ? null : dr.GetString("propertyType"),
                    HomeSize = dr.IsDBNull("size") ? null : dr.GetInt32("size"),
                    NumberOfBedrooms = dr.IsDBNull("bedrooms") ? null : dr.GetInt32("bedrooms"),
                    Amenities = dr.IsDBNull("amenities") ? null : dr.GetString("amenities"),
                    HouseYear = dr.IsDBNull("yearBuilt") ? null : dr.GetInt32("yearBuilt"),
                    Garage = dr.IsDBNull("garage") ? null : dr.GetString("garage"),
                    Utilities = dr.IsDBNull("utilities") ? null : dr.GetString("utilities"),
                    HomeDescription = dr.IsDBNull("description") ? null : dr.GetString("description"),
                    AskingPrice = dr.IsDBNull("price") ? null : dr.GetDecimal("price"),
                    State = dr.IsDBNull("state") ? null : dr.GetString("state"),
                    NumberOfBathrooms = dr.IsDBNull("bathrooms") ? null : dr.GetInt32("bathrooms"),
                    City = dr.IsDBNull("city") ? null : dr.GetString("city"),
                    SellerID = dr.IsDBNull("sellerId") ? null : dr.GetInt32("sellerId"),
                    RealEstateID = dr.IsDBNull("realtorId") ? null : dr.GetInt32("realtorId")
                }
                );
            }
            dr.Close();
            conn.Close();

            string t = JsonSerializer.Serialize(al);
            return t;
        }

        [Route("/tempDelete/id={id}")]
        [HttpDelete]
        public string Delete(int id)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=root;password=Chips90!;database=houses";
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delete_value";
            cmd.Parameters.Add(new MySqlParameter("tempid", id));
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr.Read().ToString();
        }

        [HttpPost]
        public void Post([FromBody] House house)
        {
            
        }
    }
}
