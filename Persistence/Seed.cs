using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
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