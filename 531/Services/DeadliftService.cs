using _531.Models.Lifts;

namespace _531.Services
{
    public class DeadliftService
    {
        public static void TrainingDay(string[] mainSets)
        {
            Deadlift deadlift = new Deadlift();

            double TM = deadlift.GetTM();

            Console.WriteLine(deadlift.DisplayWorkSets(mainSets, TM));

            Console.Write("Enter top set: ");
            int topSet = int.Parse(Console.ReadLine()!);
            double updatedTM = deadlift.AddToTM(topSet, TM);

            if (TM < updatedTM)
            {
                deadlift.UpdateTM(updatedTM);
            }

            return;
        }
    }
}
