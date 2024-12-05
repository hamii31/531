using _531.Models.Lifts;

namespace _531.Services
{
    public class SquatService
    {
        public static void TrainingDay(string[] mainSets)
        {
            Squat zercher = new Squat();

            double TM = zercher.GetTM();

            Console.WriteLine(zercher.DisplayWorkSets(mainSets, TM));

            Console.Write("Enter top set: ");
            int topSet = int.Parse(Console.ReadLine()!);
            double updatedTM = zercher.AddToTM(topSet, TM);

            if (TM < updatedTM)
            {
                zercher.UpdateTM(updatedTM);
            }

            return;
        }
    }
}
