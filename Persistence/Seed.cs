using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
           await SeedActivities(context);
           await SeedServices(context);
              
        }
        static async Task SeedServices(DataContext context)
        {
      if(context.HotelServices.Any()) return;
               var hotelservices=new List<HotelServices>{
                 new HotelServices{
                    ID ="001",
                    RoomNo ="101",
                    Roomtype="Suite",
                    Services="SPA",
                    SubService="S_HairSpa",
                    Price="5000"
                 },
                 new HotelServices{
                    ID ="002",
                    RoomNo ="101",
                    Roomtype="Suite",
                    Services="SPA",
                    SubService="S_Facial",
                    Price="4500"
                 },
                  new HotelServices{
                    ID ="003",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="SPA",
                    SubService="S_HairSpa",
                    Price="5000"
                 },
                  new HotelServices{
                    ID ="004",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="SPA",
                    SubService="S_Facial",
                    Price="4500"
                 },
                  new HotelServices{
                    ID ="005",
                    RoomNo ="101",
                    Roomtype="Suite",
                    Services="Restaurant",
                    SubService="R_Breakfast",
                    Price="2500"
                 },
                  new HotelServices{
                    ID ="006",
                    RoomNo ="101",
                    Roomtype="Suite",
                    Services="Restaurant",
                    SubService="R_Lunch",
                    Price="3500"
                 },
                  new HotelServices{
                    ID ="007",
                    RoomNo ="101",
                    Roomtype="Suite",
                    Services="Restaurant",
                    SubService="R_Dinner",
                    Price="2000"
                 },
                   new HotelServices{
                    ID ="008",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="Restaurant",
                    SubService="R_Breakfast",
                    Price="1500"
                 },
                   new HotelServices{
                    ID ="009",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="Restaurant",
                    SubService="R_Lunch",
                    Price="2500"
                 },
                   new HotelServices{
                    ID ="010",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="Restaurant",
                    SubService="R_Dinner",
                    Price="1500"
                 },
                   new HotelServices{
                    ID ="011",
                    RoomNo ="201",
                    Roomtype="Standard",
                    Services="Bar",
                    SubService="B_Bar",
                    Price="1500"
                 },
                   new HotelServices{
                    ID ="012",
                    RoomNo ="101",
                    Roomtype="Standard",
                    Services="Bar",
                    SubService="B_Bar",
                    Price="1500"
                 }
               };
                await context.HotelServices.AddRangeAsync(hotelservices);
                await context.SaveChangesAsync();
      }

        static async Task SeedActivities(DataContext context)
        {
          if(context.Activities.Any()) return;

            var activities=new List<Activity>{
                 new Activity{
                    Title="Past Activity 1",
                    Date=DateTime.Now.AddMonths(-2),
                    Description="Activity 2 months ago",
                    Category="drinks",
                    City="Pune",
                    Venue="Pub"
                 },
                 new Activity{
                    Title="Past Activity 2",
                    Date=DateTime.Now.AddMonths(-3),
                    Description="Activity 3 months ago",
                    Category="drinks",
                    City="Pune",
                    Venue="Pub"
                 },
                 new Activity{
                    Title="Past Activity 3",
                    Date=DateTime.Now.AddMonths(-2),
                    Description="Activity 2 months ago",
                    Category="drinks",
                    City="Pune",
                    Venue="Pub"
                 },
                 new Activity{
                    Title="Past Activity 4",
                    Date=DateTime.Now.AddMonths(-5),
                    Description="Activity 5 months ago",
                    Category="culture",
                    City="Pune",
                    Venue="Louvre"
                 },
                 new Activity{
                    Title="Past Activity 5",
                    Date=DateTime.Now.AddMonths(-1),
                    Description="Activity 1 months ago",
                    Category="culture",
                    City="Mumbai",
                    Venue="Louvre"
                 },
                 new Activity{
                    Title="Future Activity 1",
                    Date=DateTime.Now.AddMonths(1),
                    Description="Activity 1 months in future",
                    Category="drinks",
                    City="Pune",
                    Venue="Pub"
                 },
                 new Activity{
                    Title="Future Activity 2",
                    Date=DateTime.Now.AddMonths(2),
                    Description="Activity 2 months in future",
                    Category="drinks",
                    City="Hyderabad",
                    Venue="Pub"
                 }
                };
                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
        }
    }
}