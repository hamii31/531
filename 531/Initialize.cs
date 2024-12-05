namespace _531
{
    internal class Initialize
    {
        static void Main(string[] args)
        {
            string mainString = "5/3/1+";
            string[] mainSets = mainString.Split('/').ToArray();

            Console.WriteLine("Today's feat of strength:");
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday: 
                    Services.DeadliftService.TrainingDay(mainSets);
                    break;
                case DayOfWeek.Wednesday: // Bench
                    break;
                case DayOfWeek.Friday:
                    Services.SquatService.TrainingDay(mainSets);
                    break;
                case DayOfWeek.Sunday: // Press
                    break;
                default:
                    Console.WriteLine("ZzZzZ...");
                    break;
            }
        }
    }
}
