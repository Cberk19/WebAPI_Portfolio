using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Portfolio
{

    public class House
    {
        public int? HouseID { get; set; }
        public string? Address { get; set; }
        public string? PropertyType { get; set; }
        public int? HomeSize { get; set; }
        public int? NumberOfBedrooms { get; set; }
        public string? Amenities { get; set; }
        public int? HouseYear { get; set; }
        public string? Garage { get; set; }
        public string? Utilities { get; set; }
        public string? HomeDescription { get; set; }
        public decimal? AskingPrice { get; set; }
        public string? State { get; set; }
        public int? NumberOfBathrooms { get; set; }
        public string? City { get; set; }
        public int? SellerID { get; set; }
        public int? RealEstateID { get; set; }
        public House()
        {
        }

        public House(int houseID, string? address, string? propertyType, int? homeSize, int? numberOfBedrooms, string? amenities, int? houseYear, string? garage, string? utilities, string? homeDescription, decimal? askingPrice, string? state, int? numberOfBathrooms, string? city, int? sellerID, int? realEstateID)
        {
            HouseID = houseID;
            Address = address;
            PropertyType = propertyType;
            HomeSize = homeSize;
            NumberOfBedrooms = numberOfBedrooms;
            Amenities = amenities;
            HouseYear = houseYear;
            Garage = garage;
            Utilities = utilities;
            HomeDescription = homeDescription;
            AskingPrice = askingPrice;
            State = state;
            NumberOfBathrooms = numberOfBathrooms;
            City = city;
            SellerID = sellerID;
            RealEstateID = realEstateID;
        }

        public override string ToString()
        {
            return HouseID + " " + Address;
        }
    }

    public class Room
    {
        public String RoomDescription { get; set; }
        public int RoomSizeL { get; set; }
        public int RoomSizeW { get; set; }
    }

    public class Comment
    {
        public String Address { get; set; }
        public String Username { get; set; }
        public String Content { get; set; }
    }

    public class HouseImage
    {
        public string Address { get; set; }
        public String Url { get; set; }
        public String ImageDescription { get; set; }
    }

}