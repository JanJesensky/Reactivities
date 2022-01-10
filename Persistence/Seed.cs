using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;

            var activities = new List<Activity>
            {
                new Activity
                (
                    title: "Past Activity 1",
                    date: DateTime.Now.AddMonths(-2),
                    description: "Activity 2 months ago",
                    category: "drinks",
                    city: "London",
                    venue: "Pub"
                ),
                new Activity
                (
                    title: "Past Activity 2",
                    date: DateTime.Now.AddMonths(-1),
                    description:"Activity 1 month ago",
                    category: "culture",
                    city: "Paris",
                    venue: "Louvre"
                ),
                new Activity
                (
                    title: "Future Activity 1",
                    date: DateTime.Now.AddMonths(1),
                    description: "Activity 1 month in future",
                    category: "culture",
                    city: "London",
                    venue: "Natural History Museum"
                ),
                new Activity
                (
                    title: "Future Activity 2",
                    date: DateTime.Now.AddMonths(2),
                    description: "Activity 2 months in future",
                    category: "music",
                    city: "London",
                    venue: "O2 Arena"
                ),
                new Activity
                (
                    title: "Future Activity 3",
                    date: DateTime.Now.AddMonths(3),
                    description: "Activity 3 months in future",
                    category: "drinks",
                    city: "London",
                    venue: "Another pub"
                ),
                new Activity
                (
                    title: "Future Activity 4",
                    date: DateTime.Now.AddMonths(4),
                    description: "Activity 4 months in future",
                    category: "drinks",
                    city: "London",
                    venue: "Yet another pub"
                ),
                new Activity
                (
                    title: "Future Activity 5",
                    date: DateTime.Now.AddMonths(5),
                    description: "Activity 5 months in future",
                    category: "drinks",
                    city: "London",
                    venue: "Just another pub"
                ),
                new Activity
                (
                    title: "Future Activity 6",
                    date: DateTime.Now.AddMonths(6),
                    description: "Activity 6 months in future",
                    category: "music",
                    city: "London",
                    venue: "Roundhouse Camden"
                ),
                new Activity
                (
                    title: "Future Activity 7",
                    date: DateTime.Now.AddMonths(7),
                    description: "Activity 2 months ago",
                    category: "travel",
                    city: "London",
                    venue: "Somewhere on the Thames"
                ),
                new Activity
                (
                    title: "Future Activity 8",
                    date: DateTime.Now.AddMonths(8),
                    description: "Activity 8 months in future",
                    category: "film",
                    city: "London",
                    venue: "Cinema"
                )
            };

            context.Activities.AddRange(activities);
            context.SaveChanges();
        }
    }
}