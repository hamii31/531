using _531.Models.Lifts;

namespace _531.Services
{
    public class BenchService
    {
        public static void TrainingDay(string[] mainSets)
        {
            Bench bench = new Bench();

            double TM = bench.GetTM();

            Console.WriteLine(bench.DisplayWorkSets(mainSets, TM));

            Console.Write("Enter top set: ");
            int topSet = int.Parse(Console.ReadLine()!);
            double updatedTM = bench.AddToTM(topSet, TM);

            if (TM < updatedTM)
            {
                bench.UpdateTM(updatedTM);
            }

            return;
        }
    }
}
