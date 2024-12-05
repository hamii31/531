using _531.Models.Lifts;

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
                case DayOfWeek.Monday: // Deadlift
                    break;
                case DayOfWeek.Wednesday: // Bench
                    break;
                case DayOfWeek.Friday:Squat(mainSets);
                    break;
                case DayOfWeek.Sunday: // Press
                    break;
                default:
                    Console.WriteLine("ZzZzZ...");
                    break;
            }
            Squat(mainSets);
        }
        static void Squat(string[] mainSets)
        {
            Squat zercher = new Squat();

            double TM = zercher.GetTM();

            Console.WriteLine(zercher.DisplayWorkSets(mainSets, TM));

            Console.Write("Enter top set: ");
            int topSet = int.Parse(Console.ReadLine()!);
            double updatedTM = zercher.AddToTM(topSet, TM);

            if(TM < updatedTM)
            {
                zercher.UpdateTM(updatedTM);
            }

            return;
        }
    }
}
